#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9728d47ea506f0e8202325a72f9fe03e04184425"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WeatherApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using WeatherApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using WeatherApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using WeatherApp.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using WeatherDataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/forecast")]
    public partial class Forecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
      

    List<ForecastResponseModel> _forecastData;
    private LineConfig configTemp;
    private ChartJsLineChart _lineChartJs;

    protected override async Task OnInitializedAsync()
    {
        //_forecastData = new List<ForecastResponseModel>();

        _forecastData = await SqlQueries.GetTodayForecast();

        _forecastData = _forecastData.OrderBy(x => x.Date).ToList();
        
        if (_forecastData != null && _forecastData.Count != 0)
        {
            DisplayPredictedTemperature(_forecastData);
        }
        DatabaseNotifications.ReceiveNotifyCurrentWeather();
        DatabaseNotifications.OnForecastChange += SqlDataAccessOnForecastChange;
    }

    private async void SqlDataAccessOnForecastChange(object? sender, ForecastResponseModel e)
    {
        CheckIfSameDay(e.Date);
        
        _forecastData.Add(e);
        await _lineChartJs.Update();
        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
        
    }
    
    private void CheckIfSameDay(DateTime date)
    {
        var lastItem = _forecastData.LastOrDefault();
        if (lastItem != null && lastItem.Date.Day != date.Day)
        {
            _forecastData = new List<ForecastResponseModel>();
        }
    }
    
    
    private void DisplayPredictedTemperature(List<ForecastResponseModel> listForecastModels)
    {
        configTemp = new LineConfig()
        {
            Options = new LineOptions()
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = $"Prepoveď teploty pre {listForecastModels[0].Date.ToString("yyyy-MM-dd")} "
                },
                Legend = new Legend
                {
                    Display = true
                },
                Tooltips = new Tooltips
                {
                    Mode = InteractionMode.Nearest,
                    Intersect = false
                },
                Scales = new Scales
                {
                    yAxes = new List<CartesianAxis>
                    {
                        new LinearCartesianAxis
                        {
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Temperature "
                            }
                        },
                    },
                    xAxes = new List<CartesianAxis>
                    {
                        new TimeAxis
                        {
                            Distribution = TimeDistribution.Linear,
                            Ticks = new TimeTicks
                            {
                                Source = TickSource.Data
                            },
                            Time = new TimeOptions
                            {
                                Unit = TimeMeasurement.Hour,
                                Round = TimeMeasurement.Hour,
                                TooltipFormat = "DD.MM.YYYY HH:mm:ss:SSS",
                                DisplayFormats = TimeDisplayFormats.DE_CH
                            },
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Time"
                            }
                        }
                    }
                }
            }
        };

        var WeatherDataset = new LineDataset<TimeTuple<int>>
        {
            BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
            BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Red),
            Label = "Temperature",
            Fill = false,
            BorderWidth = 2,
            PointRadius = 2,
            PointBorderWidth = 2,
            SteppedLine = SteppedLine.False,
            Hidden = false
        };

        var chartData = listForecastModels.Select
            (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(_.Temp)));
        WeatherDataset.AddRange(chartData);
        configTemp.Data.Datasets.Add(WeatherDataset);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseNotifications DatabaseNotifications { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlQueries SqlQueries { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlDataAccess SqlDataAccess { get; set; }
    }
}
#pragma warning restore 1591
