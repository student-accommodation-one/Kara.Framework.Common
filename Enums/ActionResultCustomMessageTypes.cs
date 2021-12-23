using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Enums
{
    public enum ActionResultCustomMessageTypes
    {
        [Description("None")]
        None = 0,
        [Description("Success")]
        Success= 1,
        [Description("Info")]
        Info = 2,        
        [Description("Warning")]
        Warning = 3,
        [Description("Error")]
        Error = 4
    }
}
