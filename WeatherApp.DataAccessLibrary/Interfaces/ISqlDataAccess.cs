using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Common.Models;

namespace Interfaces.WeatherDataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }
        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
        Task<List<WeatherModel>> ReceiveNotify();
        event EventHandler<WeatherModel> OnWeatherChange;

    }
}