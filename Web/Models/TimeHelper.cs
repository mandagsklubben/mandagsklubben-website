using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandagsklubben.Web.Models
{
    public static class TimeHelper
    {
        /// <summary>
        /// Helper to provide the client with initial correct
        /// time until event
        /// </summary>
        /// <returns></returns>
        public static DateTime GetTimeLeft()
        {
            var eventStart = DateTime.Now.Date.ClosestWeekDay(DayOfWeek.Monday).AddHours(17);
            var timeLeft = eventStart - DateTime.Now;

            return eventStart;
        }

        /// <summary>
        /// Find the closest weekday to the given date
        /// </summary>
        /// <param name="includeStartDate">if the supplied date is on the specified day of the week, return that date or continue to the next date</param>
        /// <param name="searchForward">search forward or backward from the supplied date. if a null parameter is given, the closest weekday (ie in either direction) is returned</param>
        public static DateTime ClosestWeekDay(this DateTime date, DayOfWeek weekday, bool includeStartDate = true, bool? searchForward = true)
        {
            if (!searchForward.HasValue && !includeStartDate)
            {
                throw new ArgumentException("if searching in both directions, start date must be a valid result");
            }
            var day = date.DayOfWeek;
            int add = ((int)weekday - (int)day);
            if (searchForward.HasValue)
            {
                if (add < 0 && searchForward.Value)
                {
                    add += 7;
                }
                else if (add > 0 && !searchForward.Value)
                {
                    add -= 7;
                }
                else if (add == 0 && !includeStartDate)
                {
                    add = searchForward.Value ? 7 : -7;
                }
            }
            else if (add < -3)
            {
                add += 7;
            }
            else if (add > 3)
            {
                add -= 7;
            }
            return date.AddDays(add);
        }
    }
}