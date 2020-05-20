using System.Threading.Tasks;

namespace WeatherForecastService
{
    public interface IForecastRandomForest
    {
        Task ForecastForNexHour();
    }
}