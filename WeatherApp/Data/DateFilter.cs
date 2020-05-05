using System;

namespace WeatherApp.Data
{
    public class DateFilter
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string TypeOfData { get; set; }
    }
}