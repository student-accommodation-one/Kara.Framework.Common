using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class TypeHelper
    {
        public delegate object ObjectActivator(params object[] args);

        private static ConcurrentDictionary<ConstructorInfo, object> _activators = new ConcurrentDictionary<ConstructorInfo, object>();

        public static ObjectActivator New(this Type type, params object[] args)
        {
            Type[] argTypes = args.Select(a => a.GetType()).ToArray();

            var ctor = type.GetConstructor(argTypes);

            return GetActivator(ctor, args);
        }

        public static ObjectActivator GetActivator(ConstructorInfo ctor, object[] args)
        {
            object activator = null;
            if (_activators.TryGetValue(ctor, out activator)) return (ObjectActivator)activator;

            ParameterInfo[] paramsInfo = ctor.GetParameters();

            ParameterExpression param = Expression.Parameter(typeof(object[]), "args");

            var argsExp = new Expression[paramsInfo.Length];

            for (int i = 0; i < paramsInfo.Length; i++)
            {
                Expression index = Expression.Constant(i);

                Expression paramAccessorExp = Expression.ArrayIndex(param, index);

                Expression paramCastExp = Expression.Convert(paramAccessorExp, paramsInfo[i].ParameterType);

                argsExp[i] = paramCastExp;
            }


            NewExpression newExp = Expression.New(ctor, argsExp);


            LambdaExpression lambda = Expression.Lambda(typeof(ObjectActivator), newExp, param);


            var compiled = (ObjectActivator)lambda.Compile();

            _activators.TryAdd(ctor, compiled);

            return compiled;
        }

        public static T MapFrom<T>(this Type type, Dictionary<string, object> valueDictionary)
        {
            var properties = type.GetProperties();
            var instance = (T)type.New(System.Type.EmptyTypes).Invoke(System.Type.EmptyTypes);
            foreach (var property in properties)
            {
                if (valueDictionary.ContainsKey(property.Name))
                {
                    var value = valueDictionary[property.Name];
                    if (value != null)
                        property.SetValue(instance, Convert.ChangeType(value, property.PropertyType));
                }                         
            }
            return instance;
        }
        public static MemberInfo GetMemberInfo<T, U>(Expression<Func<T, U>> expression)
        {
            var member = expression.Body as MemberExpression;
            if (member != null)
                return member.Member;

            throw new ArgumentException("Expression is not a member access", "expression");
        }

        public static string  GetPropertyName<T>(Expression<Func<T>> propertyLambda)
        {
            var me = propertyLambda.Body as MemberExpression;

            if (me == null)
            {
                throw new ArgumentException("You must pass a lambda of the form: '() => Class.Property' or '() => object.Property'");
            }

            return me.Member.Name;
        }
    }
}
