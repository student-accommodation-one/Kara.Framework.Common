using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class ListHelper
    {
        public static int GetRandomItemValue(this List<int> list)
        {
            var random = new Random();
            return list[random.Next(0, list.Count - 1)];
        }
    }
}
