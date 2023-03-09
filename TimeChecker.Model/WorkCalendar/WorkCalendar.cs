using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeChecker.Model.Services;

namespace TimeChecker.Model.WorkCalendar
{
    public class WorkCalendar
    {
        
        public WorkCalendar()
        {
            string path = @"..\..\..\..\TimeChecker.Model\DataFiles\2023.json";

            JsonFileService service = new JsonFileService();
            JsonCalendar jsonCalendar = service.Open<JsonCalendar>(path);


        }

        private List<WorkPeriodCalculator> ConvertFromJson(JsonCalendar json)
        {
            List<WorkPeriodCalculator> workPeriods = new List<WorkPeriodCalculator>();



            return workPeriods;
            
        }
    }
}
