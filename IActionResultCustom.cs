using Kara.Framework.Common.Entity;
using Kara.Framework.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kara.Framework.Common
{
    public interface IActionResultCustom
    {
        bool IsSuccess { get; set; }
        List<ActionResultCustomMessage> Messages { get; set; }
        int TotalRows { get; set; }
    }
}
