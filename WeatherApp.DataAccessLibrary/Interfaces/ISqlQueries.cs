using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;

namespace WeatherDataAccessLibrary.Interfaces
{
    public interface ISqlQueries
    {
        Task<List<WeatherModel>> GetAllWeatherData();
        Task<List<WeatherModel>> GetHistoricalWeatherDataByDate(DateTime fromDate);
        Task<List<WeatherModel>> GetTodayWeather();
        Task<List<ForecastResponseModel>> GetTodayForecast();
        Task<List<double>> GetActualWeatherTemperature(DateTime date);
        Task InsertPredictedWeatherTemperature(ForecastResponseModel forecastResponseModel);
        Task UpdatePredictedWeatherTemperature(ForecastResponseModel forecastResponseModel);
    }
}