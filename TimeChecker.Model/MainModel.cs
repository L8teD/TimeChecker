using System.Globalization;
using TimeChecker.Model.Calendar;

namespace TimeChecker.Model
{
    public class MainModel
    {
        private System.Globalization.Calendar _calendar;
        public MainModel()
        {
            _calendar = CultureInfo.GetCultureInfo("ru-RU").Calendar;

            WorkCalendar workCalendar = new WorkCalendar();

        }
        
    }
}