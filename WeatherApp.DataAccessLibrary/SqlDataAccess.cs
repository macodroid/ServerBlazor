﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Npgsql;
using WeatherApp.Common.Models;
using WeatherDataAccessLibrary.Interfaces;

namespace WeatherDataAccessLibrary
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

    }
}