using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RestSharp;
using WeatherWorkerService.Models;

namespace WeatherWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private const string Url = "http://api.openweathermap.org/data/2.5/weather?id=3060972&appid=a4808f70587d24bd0e138fdad13df1d3&units=metric";
        private RestUtils _restUtils;
        public Worker(ILogger<Worker> logger, RestUtils restUtils)
        {
            _logger = logger;
            _restUtils = restUtils;
        }
        private RootObject GetForecast()
        {
            var client = new RestClient();
            var request = new RestRequest(Url, Method.GET);
            var response = client.Execute<RootObject>(request);
            return response.Data;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
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

                await _restUtils.InsertCurrentWeatherData(weather);
                
                _logger.LogInformation(Newtonsoft.Json.JsonConvert.SerializeObject(weather) , DateTimeOffset.Now);
                await Task.Delay(60*60*1000, stoppingToken); 
            }
        }
    }
}