using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Enums
{
    public enum RecordStates
    {
        [Description("Inactive")]
        Inactive = 0,
        [Description("Active")]
        Active = 1,
        [Description("Deleted")]
        Deleted = 2
    }
}
