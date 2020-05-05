using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WeatherApp.Common.Models
{
    public class WeatherModel
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