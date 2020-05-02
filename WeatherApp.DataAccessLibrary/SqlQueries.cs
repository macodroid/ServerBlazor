﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Interfaces.WeatherDataAccessLibrary;
using WeatherApp.Common.Models;

namespace WeatherDataAccessLibrary
{
    public class SqlQueries : ISqlQueries
    {
        private const string _schema = "ba_weather";
        private const string _table = "test";
        private const string _dateFormat = "yyyy-MM-dd";
        
        private readonly ISqlDataAccess _dataAccess;

        public SqlQueries(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        
        public Task<List<Weather>> GetAllWeatherData()
        {
            string sqlQuery = $"select * from {_schema}.{_table}";

            return _dataAccess.LoadData<Weather, dynamic>(sqlQuery, new{ });
        }
        
        public Task<List<Weather>> GetTodayWeather()
        {
            var today = DateTime.Today;
            var sqlQuery = $"select * from {_schema}.{_table} where date between \'{today.ToString(_dateFormat)}\' and  \'{today.AddDays(1).ToString(_dateFormat)}\'";

            return _dataAccess.LoadData<Weather, dynamic>(sqlQuery, new{ });
        }
        
        public Task<List<Weather>> GetWeatherDataByDates(DateTime fromDate, DateTime toDate)
        {
            toDate = toDate.AddDays(1);
            var fromDateFormat = fromDate.ToString(_dateFormat);
            var toDateFormat = toDate.ToString(_dateFormat);
            var sqlQuery = $"select * from {_schema}.{_table} where date between \'{fromDateFormat}\' and \'{toDateFormat}\'";

            return _dataAccess.LoadData<Weather, dynamic>(sqlQuery, new{ });
        }
        
        
        
        // TODO: Create query for Inserting to Database
        
    }
}