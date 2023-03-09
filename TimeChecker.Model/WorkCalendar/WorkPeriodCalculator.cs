using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.WorkCalendar
{
    public class WorkPeriodCalculator
    {
        private List<DateTime> _workdays;
        private List<DateTime> _shortdays;
        private List<DateTime> _holidays;

        public WorkPeriods Period;

        public List<DateTime> Workdays => _workdays;
        public List<DateTime> Holidays => _holidays;
        public List<DateTime> Shortdays => _shortdays;

        public WorkPeriodCalculator()
        {
            _workdays = new List<DateTime>();
            _shortdays = new List<DateTime>();
            _holidays = new List<DateTime>();
        }

        public void AddDay(TypeOfDay type, DateTime date) => SelectList(type).Add(date);
        
        private List<DateTime> SelectList(TypeOfDay type) => type switch
        {
            TypeOfDay.Work => _workdays,
            TypeOfDay.Short => _shortdays,
            TypeOfDay.Holiday => _holidays,
            _ => _workdays
        };
    }
}
