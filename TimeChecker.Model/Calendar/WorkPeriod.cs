using TimeChecker.Types;

namespace TimeChecker.Model.Calendar
{
    public class WorkPeriod
    {
        private ModelMonth monthPast;
        private ModelMonth monthNext;
        public WorkPeriods Period { get; }

        public WorkPeriod(int period, ModelMonth monthPast, ModelMonth monthNext)
        {
            Period = (WorkPeriods)period;
            this.monthPast = monthPast;
            this.monthNext = monthNext;
        }

        public List<ModelDay> GetPeriod()
        {
            List<ModelDay> result = new List<ModelDay>();
            if (monthPast != null)
                result.AddRange(monthPast?.Days.Where(day => day.Day > 19));
            if (monthNext != null)
                result.AddRange(monthNext?.Days.Where(day => day.Day < 20));

            return result;
        }
    }
}
