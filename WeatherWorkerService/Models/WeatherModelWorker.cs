using System;

namespace WeatherWorkerService.Models
{
    public class WeatherModelWorker
    {
        public DateTime Date { get; set; }
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMax { get; set; }
        public double TempMin { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public string Condition { get; set; }
        public string Icon { get; set; }

    }
}