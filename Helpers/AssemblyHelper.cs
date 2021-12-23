using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Reflection;
namespace Kara.Framework.Common.Helpers
{
    public static class  AssemblyHelper
    {
        public static Type[] GetTypesInNamespace(this Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
    }
}
