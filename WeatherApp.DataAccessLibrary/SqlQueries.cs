using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;
using WeatherDataAccessLibrary.Interfaces;

namespace WeatherDataAccessLibrary
{
    public class SqlQueries : ISqlQueries
    {
        private const string _schema = "ba_weather";
        private const string _table = "bratislava_weather";
        private const string _tableForecst = "random_forest";
        private const string _dateFormat = "yyyy-MM-dd";
        
        private readonly ISqlDataAccess _dataAccess;

        public SqlQueries(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        #region Get data from database
        
        public Task<List<WeatherModel>> GetTodayWeather()
        {
            var today = DateTime.Today;
            var sqlQuery = $"select * from {_schema}.{_table} where date between \'{today.ToString(_dateFormat)}\' and  \'{today.AddDays(1).ToString(_dateFormat)}\'";

            return _dataAccess.LoadData<WeatherModel, dynamic>(sqlQuery, new{ });
        }
        
        public Task<List<ForecastResponseModel>> GetTodayForecast()
        {
            var today = DateTime.Today;
            var sqlQuery = $"select * from {_schema}.{_tableForecst} where date between \'{today.ToString(_dateFormat)}\' and  \'{today.AddDays(1).ToString(_dateFormat)}\'";

            return _dataAccess.LoadData<ForecastResponseModel, dynamic>(sqlQuery, new{ });
        }

        public Task<List<WeatherModel>> GetHistoricalWeatherDataByDate(DateTime fromDate)
        {
            var toDate = fromDate.AddDays(1);
            var fromDateFormat = fromDate.ToString(_dateFormat);
            var toDateFormat = toDate.ToString(_dateFormat);
            var sqlQuery = $"select * from {_schema}.{_table} where date between \'{fromDateFormat}\' and \'{toDateFormat}\'";

            return _dataAccess.LoadData<WeatherModel, dynamic>(sqlQuery, new{ });
        }

        public Task<List<double>> GetActualWeatherTemperature(DateTime date)
        {
            var fromDateFormat = date.ToString(_dateFormat);
            var sqlQuery = $"select temp from {_schema}.{_table} where date = \'{fromDateFormat}\'";

            return _dataAccess.LoadData<double , dynamic>(sqlQuery, new{ });
        }

        #endregion


        #region Insert data into database
        public Task InsertPredictedWeatherTemperature(ForecastResponseModel forecastResponseModel )
        {
            var sql =
                $"INSERT INTO {_schema}.{_tableForecst} (date, temp)" +
                $" values ('{forecastResponseModel.Date.ToString("yyyy-MM-dd HH:mm:ss")}',{forecastResponseModel.Temp})";
        
            return _dataAccess.SaveData(sql, forecastResponseModel);
        }
        
        public Task InsertCurrentWeatherData(WeatherModelWorker weatherModel)
        {
            var date = weatherModel.Date;
            var newDate = new DateTime(date.Year,date.Month,date.Day,date.Hour,0,0);
            var sql =
                $"INSERT INTO {_schema}.{_table} (date, temp, pressure, humidity, condition,icon,feels_like,description)" +
                $" values ('{newDate.ToString("yyyy-MM-dd HH:mm:ss")}',{weatherModel.Temp},{weatherModel.Pressure}" +
                $" ,{weatherModel.Humidity},'{weatherModel.Condition}','{weatherModel.Icon}',{weatherModel.FeelsLike},'{weatherModel.Description}')";

            return _dataAccess.SaveData(sql, weatherModel);
        }
        
        #endregion

    }
}