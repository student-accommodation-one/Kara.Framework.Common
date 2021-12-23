using Kara.Framework.Common.Entity;
using Kara.Framework.Common.Enums;
using Kara.Framework.Common.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class EntityFilterListHelper
    {
        public static Expression<Func<TEntity, bool>> GetFilterExpression<TEntity>(this List<EntityFilter> filters, ParameterExpression parameter)
        {
            Expression<Func<TEntity, bool>> filterPredicate = null;

            if (parameter == null) parameter = Expression.Parameter(typeof(TEntity));

            for (int i = 0; i < filters.Count; i++)
            {
                var filter = filters[i];

                var memberExpr = Expression.Property(parameter, filter.Field);

                Expression constExp;
                if (memberExpr.Type != typeof(string))
                {
                    object value = TypeDescriptor.GetConverter(memberExpr.Type).ConvertFromString(filter.Value);
                    constExp = Expression.Convert(Expression.Constant(value), memberExpr.Type);
                }
                else
                {
                    constExp = Expression.Constant(filter.Value);
                }


                Expression body = null;
                MethodInfo method;
                switch (filter.Operator)
                {
                    case Kara.Framework.Common.Enums.FilterOperators.Eq:
                        body = Expression.Equal(memberExpr, constExp);
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.Neg:
                        body = Expression.NotEqual(memberExpr, constExp);
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.Gte:
                        body = Expression.GreaterThanOrEqual(memberExpr, constExp);
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.Lte:
                        body = Expression.LessThanOrEqual(memberExpr, constExp);
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.StartsWith:
                        method = typeof(string).GetMethod(filter.Operator.ToString(), new[] { typeof(string) });
                        body = Expression.Call(memberExpr, method, Expression.Constant(filter.Value));
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.EndsWith:
                        method = typeof(string).GetMethod(filter.Operator.ToString(), new[] { typeof(string) });
                        body = Expression.Call(memberExpr, method, Expression.Constant(filter.Value));
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.DoesNotContain:
                        method = typeof(string).GetMethod(FilterOperators.Contains.ToString(), new[] { typeof(string) });
                        body = Expression.Not(Expression.Call(memberExpr, method, Expression.Constant(filter.Value)));
                        break;
                    case Kara.Framework.Common.Enums.FilterOperators.Contains:
                        method = typeof(string).GetMethod(filter.Operator.ToString(), new[] { typeof(string) });
                        body = Expression.Call(memberExpr, method, Expression.Constant(filter.Value));
                        break;
                    default:
                        break;
                }

                var filterExpression = Expression<TEntity>.Lambda<Func<TEntity, bool>>(body, parameter);

                if (filterPredicate != null)
                    filterPredicate = PredicateHelper.And<TEntity>(filterPredicate, filterExpression);
                else
                    filterPredicate = filterExpression;
            }

            return filterPredicate;
        }
    }
}
