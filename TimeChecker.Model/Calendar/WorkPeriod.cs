using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Calendar
{
    public class WorkPeriod
    {
        public ModelMonth Month { get; set; }
        public WorkPeriods Period { get; }
        public WorkPeriod()
        {

        }
    }
}
