using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChecker.Model.Services
{
    public class JsonCalendar
    {
        [JsonProperty("year")]
        public int Year { get; set; }
        [JsonProperty("months")]
        public List<JsonMonth> Months { get; set; } = new List<JsonMonth>();
        [JsonProperty("statistic")]
        public JsonStatictic Statictic { get; set; } = new JsonStatictic();
    }

    public class JsonMonth
    {
        [JsonProperty("month")]
        public int Month { get; set; }
        [JsonProperty("days")]
        public string Days { get; set; }
    }

    public class JsonStatictic
    {
        [JsonProperty("workdays")]
        public int Workdays { get; set; }
        [JsonProperty("holidays")]
        public int Holidays { get; set; }
        [JsonProperty("hours40")]
        public double Hours40 { get; set; }
        [JsonProperty("hours36")]
        public double Hours36 { get; set; }
        [JsonProperty("hours24")]
        public double Hours24 { get; set; }
    }
}
