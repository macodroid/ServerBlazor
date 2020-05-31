using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WeatherForecastService.Models
{
    
    public class ForecastParametersModel
    {
        [DataMember]
        [JsonProperty(PropertyName = "year")]
        public int year { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "month")]
        public int month { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "day")]
        public int day { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "hour")]
        public int hour { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "min")]
        public int min { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "sec")]
        public int sec { get; set; }
    }
}