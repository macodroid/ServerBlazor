#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0d3526559c7a453a9e6509bf5a379037168094"
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
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using WeatherApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using WeatherApp.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
using WeatherDataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/historicalTemperature")]
    public partial class HistoricalTemperature : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
 
    private List<WeatherModel> _historicalData ;
    private DateFilter _dateFilter = new DateFilter();
    private LineConfig configTemp;
    private LineConfig configHumidity;
    private LineConfig configPressure;
    private ChartJsLineChart _lineChartJs;
    private string error = "";


    private async Task DisplayHistoricalWeatherData()
    {
        try
        {
            _historicalData = await SqlQueries.GetHistoricalWeatherDataByDate(_dateFilter.FromDate);
        }
        catch (Exception e)
        {
            error = "Neboli nájdené žiadne údaje";
            throw ;
        }
        
        if (_historicalData != null && _historicalData.Count != 0)
        {
            DisplayHistoricalTemperature(_historicalData);
            DisplayHistoricalHumidity(_historicalData);
            DisplayHistoricalPressure(_historicalData);
        }
    }
    
    private void DisplayHistoricalTemperature(List<WeatherModel> listWeatherModels)
    {
        listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        configTemp = new LineConfig()
        {
            Options = new LineOptions()
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = $"Historické údaje pre {listWeatherModels[0].Date.ToString("yyyy-MM-dd")} "
                },
                Legend = new Legend
                {
                    Display = true,
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
                                LabelString = "Teplota",
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
                                LabelString = "Čas"
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
            Label = "Teplota",
            Fill = false,
            BorderWidth = 2,
            PointRadius = 2,
            PointBorderWidth = 2,
            SteppedLine = SteppedLine.False,
            Hidden = false
        };

        var chartData = listWeatherModels.Select
            (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(Math.Ceiling(_.Temp))));
        WeatherDataset.AddRange(chartData);
        configTemp.Data.Datasets.Add(WeatherDataset);
    }
    
    private void DisplayHistoricalHumidity(List<WeatherModel> listWeatherModels)
    {
        listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        configHumidity = new LineConfig()
        {
            Options = new LineOptions()
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true
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
                                LabelString = "Vlhkosť [%]"
                            }
                        }
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
                                LabelString = "Čas"
                            }
                        }
                    }
                }
            }
        };

        var WeatherDataset = new LineDataset<TimeTuple<int>>
        {
            BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
            BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Blue),
            Label = "Vlhkosť",
            Fill = false,
            BorderWidth = 2,
            PointRadius = 2,
            PointBorderWidth = 2,
            SteppedLine = SteppedLine.False,
            Hidden = false
        };

        var chartData = listWeatherModels.Select
            (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(Math.Ceiling(_.Humidity))));
        WeatherDataset.AddRange(chartData);
        configHumidity.Data.Datasets.Add(WeatherDataset);
    }

    private void DisplayHistoricalPressure(List<WeatherModel> listWeatherModels)
    {
        listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        configPressure = new LineConfig()
        {
            Options = new LineOptions()
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true
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
                                LabelString = "Tlak [mmHg]"
                            }
                        }
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
                                LabelString = "Čas"
                            }
                        }
                    }
                }
            }
        };

        var WeatherDataset = new LineDataset<TimeTuple<int>>
        {
            BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
            BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Blue),
            Label = "Tlak",
            Fill = false,
            BorderWidth = 2,
            PointRadius = 2,
            PointBorderWidth = 2,
            SteppedLine = SteppedLine.False,
            Hidden = false
        };

        var chartData = listWeatherModels.Select
            (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(Math.Ceiling(_.Pressure))));
        WeatherDataset.AddRange(chartData);
        configPressure.Data.Datasets.Add(WeatherDataset);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlQueries SqlQueries { get; set; }
    }
}
#pragma warning restore 1591
