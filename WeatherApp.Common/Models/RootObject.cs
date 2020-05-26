using System.Collections.Generic;
using WeatherApp.Common.Models;

namespace WeatherWorkerService.Models
{
    public class RootObject
    {
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
    }
}