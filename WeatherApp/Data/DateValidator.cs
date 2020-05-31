using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Data
{
    public class DateValidator : ValidationAttribute
    {
        protected override ValidationResult
            IsValid(object value, ValidationContext validationContext)
        {
            var _date = Convert.ToDateTime(value);

            if (_date < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Zvolený dátum nesmie byť väčši ako dnešný dátum");
            }
        }
        
    }
}