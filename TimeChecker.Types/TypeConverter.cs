using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Types
{
    public static class TypeConverter
    {
        public static WorkPeriods DateTimeToPeriods(DateTime date)
        {
            int month = date.Month;
            int day = date.Day;

            WorkPeriods period = (WorkPeriods)date.Month;

            if(date.Day>=20)
                period = (WorkPeriods)(((int)period) + 1);

            return period;
        }
    }
}
