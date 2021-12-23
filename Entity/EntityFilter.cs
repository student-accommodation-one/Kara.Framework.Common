using Kara.Framework.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Entity
{
    public class EntityFilter
    {

        public string Field { get; set; }
        public FilterOperators Operator { get; set; }
        public string Value { get; set; }       
        
    }
}
