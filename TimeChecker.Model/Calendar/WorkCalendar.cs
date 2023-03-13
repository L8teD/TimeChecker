using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeChecker.Model.Services;

namespace TimeChecker.Model.Calendar
{
    public class WorkCalendar
    {
        private List<ModelMonth> months;

        public WorkCalendar()
        {
            string path = @"..\..\..\..\TimeChecker.Model\DataFiles\2023.json";

            JsonFileService service = new JsonFileService();
            JsonCalendar jsonCalendar = service.Open<JsonCalendar>(path);

            months = ConvertFromJson(jsonCalendar);
        }

        private List<ModelMonth> ConvertFromJson(JsonCalendar json)
        {
            List<ModelMonth> months = new List<ModelMonth>();


            foreach (JsonMonth jsonMonth in json.Months)
            {
                months.Add(new ModelMonth(jsonMonth.Month));
                JsonMonthToNormalMonth(jsonMonth, months[months.Count - 1]);
            }

            return months;
            
        }

        private void FillWorkDays(ModelMonth period, int month)
        {
            int year = 2023;
            for (DateTime dt = new DateTime(year, month, 1); 
                dt.Ticks < new DateTime(year, month, DateTime.DaysInMonth(2023, month)).Ticks; 
                dt = dt.AddDays(1))
            {
                if (!(period.Holidays.Contains(dt) || period.Shortdays.Contains(dt)))
                    period.Workdays.Add(dt);
            }
        }

        private void JsonMonthToNormalMonth(JsonMonth jsonMonth, ModelMonth month)
        {
            foreach (string day in jsonMonth.Days.Split(','))
            {
                bool isShort = day.Contains("*");

                int monthDay = 0;
                int.TryParse(day.Replace('*', ' ').Replace('+',' '), out monthDay);

                SetDayIntoWorkPeriod(isShort, jsonMonth.Month, monthDay, month);
                
            }

            FillWorkDays(month, jsonMonth.Month);

        }

        private void SetDayIntoWorkPeriod(bool isShort, int monthNum, int day, ModelMonth month)
        {
            if (isShort)
                month.AddDay(TypeOfDay.Short, JsonDayToDateTime(monthNum, day));
            else
                month.AddDay(TypeOfDay.Holiday, JsonDayToDateTime(monthNum, day));
        }

        private DateTime JsonDayToDateTime(int month, int day)
        {
            int year = 2023;
            return new DateTime(year, month, day);
        }

        private void GetWorkPeriods()
        {
            List<WorkPeriod> periods = new List<WorkPeriod>();
        }
    }
}
