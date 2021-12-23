using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public class HttpWebRequestHelper
    {
        public static HttpWebRequest GetRequestClient(string url)
        {
            var client = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            client.CookieContainer = new System.Net.CookieContainer();
            client.Method = "GET";
            client.UserAgent = "Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
            return client;
        }
    }
}
