using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WeatherApp.Common.Models
{
    public class Weather
    {
        private DateTime _dateAndTime { get; set; }
        
        public DateTime Date { get; set; }
        public TimeSpan Local_Time { get; set; }
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMax { get; set; }
        public double TempMin { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public string Condition { get; set; }
        public string Icon { get; set; }

        public DateTime DateAndTime
        {
            get
            {
                return  DateTime. MinValue;
            }
            set => _dateAndTime = Date+Local_Time;
        }
    }
}