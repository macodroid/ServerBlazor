using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WeatherWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        public Worker(ILogger<Worker> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var current = new CurrentWeather(_config, _logger);
            int lastHour = DateTime.Now.Hour;
            
            while (!stoppingToken.IsCancellationRequested)
            {
                if(lastHour < DateTime.Now.Hour || (lastHour == 23 && DateTime.Now.Hour == 0))
                {
                    lastHour = DateTime.Now.Hour;
                    current.GetCurrentWeatherForecast();
                }
                await Task.Delay(10000, stoppingToken); 
            }
        }

        
        
    }
}