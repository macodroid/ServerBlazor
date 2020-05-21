using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJs.Blazor.ChartJS.Common.Axes;
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;
using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.ChartJS.Common.Handlers;
using ChartJs.Blazor.ChartJS.Common.Properties;
using ChartJs.Blazor.ChartJS.Common.Time;
using ChartJs.Blazor.ChartJS.LineChart;
using ChartJs.Blazor.Util;
using WeatherApp.Common.Models;

namespace WeatherApp.Chartjs
{
    public class Charts
    {
        public static async Task DisplayHistoricalTemperature(List<WeatherModel> listWeatherModels,
            LineConfig configTemp)
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
                        Text = $"Historical Weather Data for {listWeatherModels[0].Date.ToString("yyyy-MM-dd")} "
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

            var chartData = listWeatherModels.Select
                (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(Math.Ceiling(_.Temp))));
            WeatherDataset.AddRange(chartData);
            configTemp.Data.Datasets.Add(WeatherDataset);
        }

        public static async Task DisplayHistoricalHumidity(List<WeatherModel> listWeatherModels,
            LineConfig configHumidity)
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
                                    LabelString = "Humidity %"
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
                BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Blue),
                Label = "Humidity",
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

        public static async Task DisplayHistoricalPressure(List<WeatherModel> listWeatherModels,
            LineConfig configPressure)
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
                                    LabelString = "Pressure mmHg"
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
                BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Blue),
                Label = "Pressure",
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
    }
}