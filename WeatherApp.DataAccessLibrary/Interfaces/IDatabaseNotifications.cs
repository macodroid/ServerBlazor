using System;
using WeatherApp.Common.Models;

namespace WeatherDataAccessLibrary.Interfaces
{
    public interface IDatabaseNotifications
    {
        event EventHandler<WeatherModel> OnWeatherChange;
        event EventHandler<ForecastResponseModel> OnForecastChange;
        void ReceiveNotifyCurrentWeather();
    }
}