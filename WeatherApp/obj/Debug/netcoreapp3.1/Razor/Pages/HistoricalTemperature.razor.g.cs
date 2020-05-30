#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2861bd6cf86dde20582b9423dd930a404fd44317"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, @"<style>
    div.line_chart{
        width: 900px;
        margin: 0 auto;
    }
    div.dateInput{
        text-align: center;
    }
    table.table{
        width: 75% ;
        text-align: center;
        margin: 0 auto;
    }
    h2.daily{
        margin: 3% 0 3% 12%;
    }
</style>

");
            __builder.AddMarkupContent(1, "<h1>Historické údaje o počasí v meste Bratislava</h1>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 40 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                  _dateFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 40 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                DisplayHistoricalWeatherData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "dateInput");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.AddMarkupContent(10, "<label>Dátum</label>\n        ");
                __Blazor.WeatherApp.Pages.HistoricalTemperature.TypeInference.CreateInputDate_0(__builder2, 11, 12, "fromDate", 13, 
#nullable restore
#line 43 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                              _dateFilter.FromDate

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _dateFilter.FromDate = __value, _dateFilter.FromDate)), 15, () => _dateFilter.FromDate);
                __builder2.AddMarkupContent(16, "\n        ");
                __builder2.AddMarkupContent(17, "<button type=\"submit\" class=\"btn btn-success\" style=\"margin-left: 15px\">Zobraz</button>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n\n");
#nullable restore
#line 48 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
 if (error != String.Empty)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.OpenElement(21, "h1");
            __builder.AddContent(22, 
#nullable restore
#line 50 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
         error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#nullable restore
#line 51 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 53 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
 if (_historicalData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.AddMarkupContent(26, "<p><em>Zvoľte dátum pre historické udaje</em></p>\n");
#nullable restore
#line 56 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.AddMarkupContent(28, "<h3>Historické údaje o počasí</h3>\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "line_chart");
            __builder.AddMarkupContent(31, " \n        ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsLineChart>(32);
            __builder.AddAttribute(33, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.LineChart.LineConfig>(
#nullable restore
#line 61 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                       configTemp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 61 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                          50

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 61 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                                      20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(36, (__value) => {
#nullable restore
#line 61 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                _lineChartJs = (ChartJs.Blazor.Charts.ChartJsLineChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "line_chart");
            __builder.AddMarkupContent(41, " \n        ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsLineChart>(42);
            __builder.AddAttribute(43, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.LineChart.LineConfig>(
#nullable restore
#line 64 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                       configHumidity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 64 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                              50

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 64 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                                          20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(46, (__value) => {
#nullable restore
#line 64 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                _lineChartJs = (ChartJs.Blazor.Charts.ChartJsLineChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "line_chart");
            __builder.AddMarkupContent(51, " \n        ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsLineChart>(52);
            __builder.AddAttribute(53, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.LineChart.LineConfig>(
#nullable restore
#line 67 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                       configPressure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 67 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                              50

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 67 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                                          20

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(56, (__value) => {
#nullable restore
#line 67 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                _lineChartJs = (ChartJs.Blazor.Charts.ChartJsLineChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
            __builder.AddContent(59, "    ");
            __builder.AddMarkupContent(60, "<h2 class=\"daily\">Denné pozorovania</h2>\n");
            __builder.AddContent(61, "    ");
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "class", "table");
            __builder.AddMarkupContent(64, "\n        ");
            __builder.AddMarkupContent(65, @"<thead>
        <tr>
            <th>Čas</th>
            <th>Teplota</th>
            <th>Pocitová teplota</th>
            <th>Tlak</th>
            <th>Vlhkosť</th>
            <th>Ikona</th>
            <th>Podmienky</th>
            <th>Popis</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(66, "tbody");
            __builder.AddMarkupContent(67, "\n");
#nullable restore
#line 86 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
         foreach (var data in _historicalData)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "            ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\n                ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "style", "vertical-align: middle");
            __builder.AddContent(73, 
#nullable restore
#line 89 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                     data.Date.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "style", "vertical-align: middle");
            __builder.AddContent(77, 
#nullable restore
#line 90 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    Math.Ceiling(data.Temp)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(78, "&deg");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "style", "vertical-align: middle");
            __builder.AddContent(82, 
#nullable restore
#line 91 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    Math.Ceiling(data.Feels_Like)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(83, "&deg");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n                ");
            __builder.OpenElement(85, "td");
            __builder.AddAttribute(86, "style", "vertical-align: middle");
            __builder.AddContent(87, 
#nullable restore
#line 92 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    data.Pressure

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, " (mmHg)");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n                ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "style", "vertical-align: middle");
            __builder.AddContent(92, 
#nullable restore
#line 93 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    data.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\n                ");
            __builder.OpenElement(95, "td");
            __builder.AddAttribute(96, "style", "vertical-align: middle");
            __builder.AddMarkupContent(97, "\n                    ");
            __builder.OpenElement(98, "img");
            __builder.AddAttribute(99, "src", "http://openweathermap.org/img/wn/" + (
#nullable restore
#line 95 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                                data.Icon.Trim()

#line default
#line hidden
#nullable disable
            ) + "@" + "2x.png");
            __builder.AddAttribute(100, "alt", "icon of weather condition");
            __builder.AddAttribute(101, "height", "50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "       \n                ");
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "style", "vertical-align: middle");
            __builder.AddContent(106, 
#nullable restore
#line 97 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    data.Condition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n                ");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "style", "vertical-align: middle");
            __builder.AddContent(110, 
#nullable restore
#line 98 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
                                                    data.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\n");
#nullable restore
#line 100 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\n");
#nullable restore
#line 103 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalTemperature.razor"
 
    private List<WeatherModel> _historicalData ;
    private DateFilter _dateFilter = new DateFilter();
    private LineConfig configTemp;
    private LineConfig configHumidity;
    private LineConfig configPressure;
    ChartJsLineChart _lineChartJs;
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
            await DisplayHistoricalTemperature(_historicalData);
            await DisplayHistoricalHumidity(_historicalData);
            await DisplayHistoricalPressure(_historicalData);
        }

    }


    private async Task DisplayHistoricalTemperature(List<WeatherModel> listWeatherModels)
    {
        if (listWeatherModels.Count > 25)
        {
            listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        }
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
    
    private async Task DisplayHistoricalHumidity(List<WeatherModel> listWeatherModels)
    {
        if (listWeatherModels.Count > 25)
        {
            listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        }
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

    private async Task DisplayHistoricalPressure(List<WeatherModel> listWeatherModels)
    {
        if (listWeatherModels.Count > 25)
        {
            listWeatherModels.RemoveAt(listWeatherModels.Count - 1);
        }
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
namespace __Blazor.WeatherApp.Pages.HistoricalTemperature
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
