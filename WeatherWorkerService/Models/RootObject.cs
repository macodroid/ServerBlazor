using System.Collections.Generic;
namespace WeatherWorkerService.Models
{
    public class RootObject
    {
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
    }
}