using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WeatherForecastService
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
            var forecast = new ForecastRandomForest(_config);
            var lastHour = DateTime.Now.Hour;
            
            while (!stoppingToken.IsCancellationRequested)
            {
               
                if(lastHour < DateTime.Now.Hour || (lastHour == 23 && DateTime.Now.Hour == 0))
                {
                    lastHour = DateTime.Now.Hour;
                    
                    forecast.ForecastForNexHour();

                }
                await Task.Delay(5000, stoppingToken); 
            }
        }
    }
}