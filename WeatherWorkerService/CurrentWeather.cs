using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using WeatherApp.Common.Models;
using WeatherDataAccessLibrary;
using WeatherDataAccessLibrary.Interfaces;
using WeatherWorkerService.Models;

namespace WeatherWorkerService
{
    public class CurrentWeather
    {
        private string ApiUrl { get; set; }

        private readonly IConfiguration _config;
        private ISqlQueries _sqlQueries;
        private ISqlDataAccess _sqlDataAccess;
        private readonly ILogger<Worker> _logger;

        public CurrentWeather(IConfiguration config, ILogger<Worker> logger)
        {
            _config = config;
            _logger = logger;
        }
        
        public async Task GetCurrentWeatherForecast()
        {
            _sqlDataAccess = new SqlDataAccess(_config);
            _sqlQueries = new SqlQueries(_sqlDataAccess);
            
            ApiUrl = _config.GetSection("WeatherApi").GetSection("ApiUrl").Value;
            
            var apiData = GetForecast();
                
            var weather = new WeatherModelWorker()
            {
                Date = DateTime.Now,
                Temp = apiData.main.Temp,
                FeelsLike = apiData.main.FeelsLike,
                Pressure = apiData.main.Pressure,
                Humidity = apiData.main.Humidity,
                Condition = apiData.weather[0].main,
                Description = apiData.weather[0].description,
                Icon = apiData.weather[0].icon
                    
            };

            await _sqlQueries.InsertCurrentWeatherData(weather);
                
            _logger.LogInformation(Newtonsoft.Json.JsonConvert.SerializeObject(weather) , DateTimeOffset.Now);

        }
        
        private RootObject GetForecast()
        {
            var client = new RestClient();
            var request = new RestRequest(ApiUrl, Method.GET);
            var response = client.Execute<RootObject>(request);
            return response.Data;
        }

    }
}