using System;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Npgsql;
using WeatherApp.Common.Models;
using WeatherDataAccessLibrary.Interfaces;

namespace WeatherDataAccessLibrary
{
    public class DatabaseNotifications : IDatabaseNotifications
    {
        private readonly IConfiguration _config;
        
        public event EventHandler<WeatherModel> OnWeatherChange;
        public event EventHandler<ForecastResponseModel> OnForecastChange;
        public string ConnectionStringName { get; set; } = "Default";

        public DatabaseNotifications(IConfiguration config)
        {
            _config = config;
        }
        
        public async void ReceiveNotifyCurrentWeather()
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new NpgsqlCommand("LISTEN weather_insert", connection).ExecuteNonQuery();
                connection.Notification += async (o, e) =>
                {
                    var jsonNotify = JObject.Parse(e.Payload);
                    if (jsonNotify.Count == 3)
                    {
                        var forecastData = jsonNotify.ToObject<ForecastResponseModel>();
                        OnForecastChange?.Invoke(this, forecastData);
                    }
                    else
                    {
                        var weatherData = jsonNotify.ToObject<WeatherModel>();
                        OnWeatherChange?.Invoke(this, weatherData);
                    }
                };

                while (true)
                {
                    await connection.WaitAsync();
                }
            }
        }
    }
}