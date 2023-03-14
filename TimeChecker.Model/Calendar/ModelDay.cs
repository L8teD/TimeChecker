using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Calendar
{
    public class ModelDay
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public TypeOfDay DayType { get; set; }

        public ModelDay(TypeOfDay type, int day, int month)
        {
            Day = day;
            Month = month;
            DayType = type;
        }
    }
}
