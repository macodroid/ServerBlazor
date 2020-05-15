using System;
using System.ComponentModel;

namespace WeatherApp.Data
{
    public class DateFilter
    {
        
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; }
        public string TypeOfData { get; set; }
    }
}