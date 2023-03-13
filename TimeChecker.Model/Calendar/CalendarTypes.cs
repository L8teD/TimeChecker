using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Calendar
{
    public static class CalendarHelper
    {
        public static readonly List<DateTime> Holidays;

        static CalendarHelper()
        {
            Holidays = new List<DateTime>();

            Holidays.Add(new DateTime());
        }
    }

    public enum Months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public enum WorkPeriods
    {
        Jan_Feb,
        Feb_Mar,
        Mar_Apr,
        Apr_May,
        May_Jun,
        Jun_Jul,
        Jul_Aug,
        Aug_Sep,
        Sep_Oct,
        Oct_Nov,
        Nov_Dec,
        Dec_Jan
    }

    public enum TypeOfDay
    {
        Work,
        Short,
        Holiday
    }
}
