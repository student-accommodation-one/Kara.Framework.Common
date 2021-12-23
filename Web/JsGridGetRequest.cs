using Kara.Framework.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Kara.Framework.Common.Helpers;
using Kara.Framework.Common.Entity;

namespace Kara.Framework.Common.Web
{
    public class JsGridGetRequest : EntityDataRequest
    {
        public JsGridGetRequest(HttpRequestBase request) : base()
        {
            Page = request.QueryString["page"].ToNullable<int>();
            PageSize = request.QueryString["pageSize"].ToNullable<int>();
            Skip = request.QueryString["skip"].ToNullable<int>();
            Take = request.QueryString["take"].ToNullable<int>();
            SortField = request.QueryString["sort[0][field]"];
            var sortDirection = request.QueryString["sort[0][dir]"];
            if (!string.IsNullOrWhiteSpace(sortDirection))
                SortDirection = (SortDirections) EnumHelper.ParseValue(typeof(SortDirections),sortDirection);
            
            if (!PageSize.HasValue)
                PageSize = 20;
            if (!Skip.HasValue)
                Skip = 0;

            InitializeFilters(request);
        }

        /// <summary>
        ///[4]	"filter[logic]"	object {string}
        ///[5]	"filter[filters][0][field]"	object {string}
        ///[6]	"filter[filters][0][operator]"	object {string}
        ///[7]	"filter[filters][0][value]"	object {string}
        ///[8]	"filter[filters][1][field]"	object {string}
        ///[9]	"filter[filters][1][operator]"	object {string}
        ///[10]	"filter[filters][1][value]"	object {string}
        /// </summary>
        /// <param name="request"></param>
        private void InitializeFilters(HttpRequestBase request)
        {
            var filters = request.QueryString.AllKeys.Where(k => k.StartsWith("filter[filters]"));

            for (int i = 0; i < filters.Count(); i++)
            {
                var filterKey = filters.ElementAt(i);
                var splittedKeys = filterKey.Split(new[] { ']' });
                var filterIndex = int.Parse(splittedKeys[1].Substring(1, splittedKeys[1].Length - 1));
                EntityFilter filter;
                if (Filters.Count - 1 < filterIndex)
                {
                    filter = new EntityFilter();
                    Filters.Add(filter);
                }
                else
                    filter = Filters[filterIndex];

                switch (splittedKeys[2].Replace("[", ""))
                {
                    case "field":
                        filter.Field = request.QueryString[filterKey];
                        break;
                    case "operator":
                        filter.Operator = (FilterOperators)Enum.Parse(typeof(FilterOperators), request.QueryString[filterKey], true);
                        break;
                    case "value":
                        filter.Value = request.QueryString[filterKey];
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
