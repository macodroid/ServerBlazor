using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Data
{
    public class DateFilter
    {
        [Required]
        // [DateTimeConstant()]
        [DateValidator(ErrorMessage = "Join Date can not be greater than current date")]
        public DateTime FromDate { get; set; } = DateTime.Now;
        private string validDate = DateTime.Now.ToString();
    }
}