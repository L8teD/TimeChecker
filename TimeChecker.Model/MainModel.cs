using System.Globalization;
using TimeChecker.Model.Services;

namespace TimeChecker.Model
{
    public class MainModel
    {
        private Calendar _calendar;
        public MainModel()
        {
            _calendar = CultureInfo.GetCultureInfo("ru-RU").Calendar;

            
        }
        
    }
}