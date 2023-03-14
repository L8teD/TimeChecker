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
        private List<WorkPeriod> workPeriods;

        public WorkCalendar()
        {
            string path = @"..\..\..\..\TimeChecker.Model\DataFiles\2023.json";

            JsonFileService service = new JsonFileService();
            JsonCalendar jsonCalendar = service.Open<JsonCalendar>(path);

            workPeriods = GetWorkPeriods(ConvertFromJson(jsonCalendar));
            var period = workPeriods[0].GetPeriod();
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

        private void FillWorkDays(ModelMonth month, int monthNumber)
        {
            int year = 2023;
            for (DateTime dt = new DateTime(year, monthNumber, 1); 
                dt.Ticks <= new DateTime(year, monthNumber, DateTime.DaysInMonth(2023, monthNumber)).Ticks; 
                dt = dt.AddDays(1))
            {
                if (!month.Days.Any(day => day.Day == dt.Day))
                    month.AddDay(TypeOfDay.Work, dt);
            }
        }

        private void JsonMonthToNormalMonth(JsonMonth jsonMonth, ModelMonth month)
        {
            foreach (string day in jsonMonth.Days.Split(','))
            {
                bool isShort = day.Contains("*");

                int monthDay = 0;
                int.TryParse(day.Replace('*', ' ').Replace('+',' '), out monthDay);

                SetDayIntoMonthModel(isShort, jsonMonth.Month, monthDay, month);
                
            }

            FillWorkDays(month, jsonMonth.Month);

        }

        private void SetDayIntoMonthModel(bool isShort, int monthNum, int day, ModelMonth month)
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

        private List<WorkPeriod> GetWorkPeriods(List<ModelMonth> months)
        {
            List<WorkPeriod> periods = new List<WorkPeriod>();

            for(int i = 0; i <= months.Count; i++)
            {
                try
                {
                    if (i == 0)
                        periods.Add(new WorkPeriod(i, null, months[i]));
                    else if (i == months.Count)
                        periods.Add(new WorkPeriod(i, months[i - 1], null));
                    else
                        periods.Add(new WorkPeriod(i, months[i - 1], months[i]));

                }
                catch(Exception ex)
                {

                }

            }

            return periods;
        }
    }
}
