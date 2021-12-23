using Kara.Framework.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Kara.Framework.Common.Helpers;

namespace Kara.Framework.Common.Entity
{
    public class EntityDataRequest
    {
        private List<EntityFilter> _filters = new List<EntityFilter>();

        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public int? Skip { get; set; }
        public int? Take { get; set; }
        public string SortField { get; set; }
        public SortDirections SortDirection { get; set; }
        public List<EntityFilter> Filters
        {
            get { return _filters; }
            set { _filters = value; }
        }

        public EntityDataRequest()
        {
            Page = 1;
            PageSize = 20;
            Skip = 0;
            Take = PageSize;
        }
    }
}
