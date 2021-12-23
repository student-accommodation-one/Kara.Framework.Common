using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Enums
{
    public enum FilterOperators
    {
        [Code("eq")]
        [Description("Equal to")]
        Eq,
        [Code("neq")]
        [Description("Not equal to")]
        Neg,
        [Code("gte")]
        [Description("Greater than or equal to")]
        Gte,
        [Code("lte")]
        [Description("Less than or equal to")]
        Lte,
        [Code("startswith")]
        [Description("Starts with")]
        StartsWith,
        [Code("endswith")]
        [Description("Ends with")]
        EndsWith,
        [Code("doesnotcontain")]
        [Description("Doesn't contain")]
        DoesNotContain,
        [Code("contains")]
        [Description("Contains")]
        Contains
    }
}
