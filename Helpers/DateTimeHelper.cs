using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kara.Framework.Common.Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTime ToLocalTimeZone(this DateTime value, TimeZoneInfo timeZoneInfo)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(value, timeZoneInfo);
        }

        public static DateTime ToUtcTime(this DateTime value, TimeZoneInfo timeZoneInfo)
        {
            return TimeZoneInfo.ConvertTimeToUtc(value, timeZoneInfo);
        }

        public static DateTime ToEndOfDayTime(this DateTime value)
        {
            return value.Subtract(value.TimeOfDay).Add(new TimeSpan(0, 23, 59, 59, 999));
        }

        public static DateTime ToStartOfDayTime(this DateTime value)
        {
            return value.Subtract(value.TimeOfDay);
        }

    }
}
