using System.Globalization;
using TimeChecker.Model.Calendar;

namespace TimeChecker.Model
{
    public class MainModel
    {
        private System.Globalization.Calendar _calendar;
        private WorkCalendar _workCalendar;

        public MainModel()
        {
            _calendar = CultureInfo.GetCultureInfo("ru-RU").Calendar;

            _workCalendar = new WorkCalendar();

        }

        public List<WorkPeriod> GetWorkPeriods() => _workCalendar?.WorkPeriods;

    }
}