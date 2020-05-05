using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;

namespace Interfaces.WeatherDataAccessLibrary
{
    public interface ISqlQueries
    {
        Task<List<WeatherModel>> GetAllWeatherData();
        Task<List<WeatherModel>> GetWeatherDataByDates(DateTime fromDate, DateTime toDate);
        Task<List<WeatherModel>> GetTodayWeather();
        //Task InsertCurrentWeatherData(WeatherModel weatherModel);
    }
}