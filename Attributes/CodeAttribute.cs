using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common
{

    [AttributeUsage(AttributeTargets.All)]
    public class CodeAttribute : Attribute
    {
        public string Code { get; set; }

        public CodeAttribute(string code)
        {
            Code = code;
        }

    }

}
