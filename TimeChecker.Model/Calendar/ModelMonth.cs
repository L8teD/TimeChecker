using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Calendar
{
    public class ModelMonth
    {
        private List<DateTime> _workdays;
        private List<DateTime> _shortdays;
        private List<DateTime> _holidays;

        private Months _month;

        public Months Month => _month;

        public List<DateTime> Workdays => _workdays;
        public List<DateTime> Holidays => _holidays;
        public List<DateTime> Shortdays => _shortdays;

        public ModelMonth(int monthNumber)
        {
             Enum.TryParse(Enum.GetName(typeof(Months), monthNumber - 1), out _month); 

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
