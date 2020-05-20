using System;

namespace WeatherApp.Common.Models
{
    public class ForecastResponseModel
    {
        public DateTime Date { get; set; }
        public int Temp { get; set; }
        public double Actual { get; set; }
    }
}