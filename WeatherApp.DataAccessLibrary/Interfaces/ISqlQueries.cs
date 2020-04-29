using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;

namespace Interfaces.WeatherDataAccessLibrary
{
    public interface ISqlQueries
    {
        Task<List<Weather>> GetAllWeatherData();
        Task<List<Weather>> GetWeatherDataByDates(DateTime fromDate, DateTime toDate);
    }
}