using System.Threading.Tasks;
using Dapper;
using Npgsql;
using WeatherWorkerService.Models;

namespace WeatherWorkerService
{
    public class RestUtils
    {
        private const string _schema = "ba_weather";
        private const string _table = "test";
        private const string _dateFormat = "yyyy-MM-dd";
        
        
        
        private async Task SaveData<T>(string sql, T parameters)
        {
            var connectionString = "Host=147.175.106.248;Database=db_macko;Username=xmacko;Password=c605;Persist Security Info=True";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
        
        public Task InsertCurrentWeatherData(WeatherModelWorker weatherModel)
        {
            var sql =
                $"INSERT INTO {_schema}.{_table} (date, temp, pressure, humidity)" +
                $" values ('{weatherModel.Date}',{weatherModel.Temp},{weatherModel.Pressure}," +
                $"{weatherModel.Humidity})";

            return SaveData(sql, weatherModel);
        }
        
        
    }
}