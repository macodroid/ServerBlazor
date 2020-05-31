using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RestSharp;
using WeatherApp.Common.Models;
using WeatherDataAccessLibrary;
using WeatherDataAccessLibrary.Interfaces;
using WeatherForecastService.Models;

namespace WeatherForecastService
{
    public class ForecastRandomForest
    {
        private string Url { get; set; }

        private readonly IConfiguration _config;
        private ISqlQueries _sqlQueries;
        private ISqlDataAccess _sqlDataAccess;
        private readonly ILogger<Worker> _logger;
        
        public ForecastRandomForest(IConfiguration config, ILogger<Worker> logger)
        {
            _config = config;
            _logger = logger;
        }

        public async Task ForecastForNexHour()
        {
            _sqlDataAccess = new SqlDataAccess(_config);
            _sqlQueries = new SqlQueries(_sqlDataAccess);

            Url = _config.GetSection("WeatherForecastConfig").GetSection("RandomForestUrl").Value;

            var dateNow = DateTime.Now.AddHours(1);

            int temperature = GetForecastTemperature(dateNow, Url);

            var predictedTemperature = new ForecastResponseModel
            {
                Date = dateNow,
                Temp = temperature,
            };
            _logger.LogInformation(Newtonsoft.Json.JsonConvert.SerializeObject(predictedTemperature),
                DateTimeOffset.Now);
            await _sqlQueries.InsertPredictedWeatherTemperature(predictedTemperature);

        }

        private static ForecastParametersModel SetParameters(DateTime date)
        {
            ForecastParametersModel forecastResponseModel = new ForecastParametersModel
            {
                year = date.Year,
                month = date.Month,
                day = date.Day,
                hour = date.Hour,
                min = date.Minute,
                sec = date.Second
            };
            return forecastResponseModel;
        }

        private static int GetForecastTemperature(DateTime dateNow, string url)
        {
            var client = new RestClient();
            var request = new RestRequest(url, Method.POST);
            var parameters = SetParameters(dateNow);
            request.AddJsonBody(parameters);
            var response = client.Execute<ForecastResponseModel>(request);
            return response.Data.Temp;
        }
    }
}