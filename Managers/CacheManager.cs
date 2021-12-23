using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace Kara.Framework.Common.Managers
{
    public class CacheManager
    {
        public static void Set<T>(string key, T value, DateTime? expiryDate, string additionalKey = null)
        {
            DateTime? cacheExpiryDate = expiryDate;
            if (!cacheExpiryDate.HasValue)
                cacheExpiryDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, 23, 59, 59);
            var cacheKey = ConstructCacheKey(key, additionalKey);

            HttpRuntime.Cache.Insert(cacheKey.ToString(), value, null, cacheExpiryDate.Value, TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, null);
        }

        private static string ConstructCacheKey(string key, string additionalKey)
        {
            var cacheKey = key.ToString();
            if (string.IsNullOrWhiteSpace(additionalKey) == false)
                cacheKey = string.Format("Kara.CacheManager.{0}.{1}", cacheKey, additionalKey);
            return cacheKey;
        }

        public static T Get<T>(string key, string additionalKey = null)
        {
            var cacheKey = ConstructCacheKey(key, additionalKey);
            return (T)HttpRuntime.Cache[cacheKey.ToString()];
        }

        public static void RemoveOutputCache(string path)
        {
            System.Web.HttpResponse.RemoveOutputCacheItem(path);
        }
    }
}
