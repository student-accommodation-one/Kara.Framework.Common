using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class StringHelper
    {
        public static string ToCleanAlphaNumericSpaceCommaDashAndQuoteOnly(this string s)
        {
            return Regex.Replace(s, @"[^a-zA-Z0-9\s\,\-']", string.Empty);
        }
        public static string ToCleanAlphaNumericSpaceOnly(this string s)
        {
            return Regex.Replace(s, @"[^a-zA-Z0-9\s']", string.Empty);
        }
        public static string ToTitleCase(this string s)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(s);
        }
        public static Nullable<T> ToNullable<T>(this string s) where T : struct
        {
            Nullable<T> result = new Nullable<T>();
            try
            {
                if (!string.IsNullOrEmpty(s) && s.Trim().Length > 0)
                {
                    var conv = TypeDescriptor.GetConverter(typeof(T));
                    result = (T)conv.ConvertFrom(s);
                }
            }
            catch { }
            return result;
        }

        public static string GetRandomPascal (this string s, int length)
        {
            if (length <= 1) length = 1;
            var chars = "abcdefghijklmnopqrstuvwxyz";//0123456789
            var random = new Random();
            var array = Enumerable.Repeat(chars, length).Select(d => d[random.Next(d.Length)]).ToArray();
            array[0] = Char.Parse(array[0].ToString().ToUpper());
            var result = new string(array);

            return result;
        }


        //Sat Jul 05 2014 00:00:00 GMT+0700 (SE Asia Standard Time)
        public static Nullable<DateTime> ParseJSDate(this string value)
        {
            var gmtIndex = value.IndexOf("GMT");
         
            try
            {
                var length = gmtIndex < 0 ? value.Length : gmtIndex;

                var dateTimeString = value.Substring(0, length);
                return DateTime.Parse(dateTimeString);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static decimal ToDecimalZeroPrecision(this string value)
        {
            return decimal.Parse(Regex.Replace(value, @"[^\d]", ""));
        }
    }
}
