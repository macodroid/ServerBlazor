using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Npgsql;
using WeatherApp.Common.Models;

namespace Interfaces.WeatherDataAccessLibrary
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public event EventHandler<WeatherModel> OnWeatherChange;
        public string ConnectionStringName { get; set; } = "Default";

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);

            using (var connection = new NpgsqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }
        
        public async Task SaveData<T>(string sql, T parameters)
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);

            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<List<WeatherModel>> ReceiveNotify()
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var cmd = new NpgsqlCommand("LISTEN weather_insert", connection).ExecuteNonQuery();
                connection.Notification += async (o, e) =>
                {
                    var jsonNotify = JObject.Parse(e.Payload);
                    var weatherData = jsonNotify.ToObject<WeatherModel>();
                    OnWeatherChange?.Invoke(this, weatherData);
                };

                while (true)
                {
                    await connection.WaitAsync();
                }
            }
        }
        
    }
}