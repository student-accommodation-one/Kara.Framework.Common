using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class DictionaryExtensions
    {
        public static string GetValue(this Dictionary<string,string> dictionary, string fieldKey, bool stringEmptyForNull)
        {
             return dictionary.ContainsKey(fieldKey) ? dictionary[fieldKey] : (stringEmptyForNull ? "" : null);
        }        
    }
}
