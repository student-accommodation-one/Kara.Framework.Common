using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class EnumHelper
    {
        
        public static Enum ParseValue(Type enumType, string value)
        {
            if (!string.IsNullOrEmpty(value))
                return (Enum)Enum.Parse(enumType, value, true);

            return null;
        }

        public static Enum ParseValue<T>(Type enumType, T value)
            where T : struct
        {
            var baseType = Enum.GetUnderlyingType(enumType);

            if (typeof(T) != baseType || !Enum.IsDefined(enumType, value))
                return null;

            return (Enum)Enum.ToObject(enumType, value);
        }

        public static Enum ParseDescriptionOrValue(Type enumType, string value)
        {
            foreach (Enum val in Enum.GetValues(enumType))
            {
                if (GetDescriptionOrValue(val).Equals(value))
                    return val;
            }
            return null;
        }

        public static bool DescriptionOrValueIsValid(Type enumType, string value)
        {
            return Enum.GetValues(enumType).Cast<Enum>().Any(val => GetDescriptionOrValue(val).Equals(value));
        }

        public static string GetDescriptionOrValue(this Enum value)
        {
            var descriptionAttributeArray = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descriptionAttributeArray.Length > 0 ? descriptionAttributeArray[0].Description : value.ToString();
        }

        public static string GetDescriptionOrValue<T>(Type enumType, T value)
            where T : struct
        {
            var enumValue = ParseValue(enumType, value);
            var descriptionAttributeArray = (DescriptionAttribute[])enumValue.GetType().GetField(enumValue.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return descriptionAttributeArray.Length > 0
                ? descriptionAttributeArray[0].Description
                : enumValue.ToString();
        }

        public static string GetCode(this Enum value)
        {
            var codeAttributes = (CodeAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CodeAttribute), false);
            return codeAttributes.Length > 0 ? codeAttributes[0].Code : string.Empty;
        }

        public static T GetCustomAttribute<T>(this Enum value)
        {
            var type = value.GetType();
            MemberInfo[] info = type.GetMember(value.ToString());
            if ((info != null) && (info.Length > 0))
            {
                object[] attrs = info[0].GetCustomAttributes(typeof(T), false);
                if ((attrs != null) && (attrs.Length > 0))
                {
                    return (T)attrs[0];
                }
            }
            return default(T);
        }
    }
}
