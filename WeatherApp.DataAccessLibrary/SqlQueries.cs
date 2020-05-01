using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;

namespace Interfaces.WeatherDataAccessLibrary
{
    public class SqlQueries : ISqlQueries
    {
        private const string _schema = "ba_weather";
        private const string _table = "test";
        
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
        
        public Task<List<Weather>> GetWeatherDataByDates(DateTime fromDate, DateTime toDate)
        {
            toDate = toDate.AddDays(1);
            var fromDateFormat = fromDate.ToString("yyyy-MM-dd");
            var toDateFormat = toDate.ToString("yyyy-MM-dd");
            var sqlQuery = $"select * from {_schema}.{_table} where date between \'{fromDateFormat}\' and \'{toDateFormat}\'";

            return _dataAccess.LoadData<Weather, dynamic>(sqlQuery, new{ });
        }

        // TODO: Create query for Inserting to Database
        
    }
}