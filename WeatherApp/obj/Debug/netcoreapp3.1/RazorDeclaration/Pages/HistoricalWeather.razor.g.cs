#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be14d30b2839e806171597f96f925288756b0c5c"
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
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using WeatherApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using WeatherApp.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using Interfaces.WeatherDataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/historicalWeather")]
    public partial class HistoricalWeather : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/HistoricalWeather.razor"
 
    private List<WeatherModel> _historicalData ;
    private DateFilter _dateFilter = new DateFilter();
    private LineConfig _config;
    private ChartJsLineChart _lineChartJs;
    private LineDataset<TimeTuple<int>> _WeatherDataset;

    private async Task DisplayHistoricalDataBetweenDates()
    {
        _historicalData = await SqlQueries.GetWeatherDataByDates(_dateFilter.FromDate, _dateFilter.ToDate);
        _historicalData.RemoveAt(_historicalData.Count-1);
        _config = new LineConfig()
         {
             Options = new LineOptions()
             {
                 Responsive = true,
                 Title = new OptionsTitle
                 {
                     Display = true,
                     Text = $"Historical Weather Data from {_dateFilter.FromDate.ToString("yyyy-MM-dd")} to {_dateFilter.ToDate.ToString("yyyy-MM-dd")} "
                 },
                 Legend = new Legend
                 {
                     Display = false
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
                                 LabelString = "Temperature"
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
                                 Unit = TimeMeasurement.Millisecond,
                                 Round = TimeMeasurement.Millisecond,
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
        
        var _WeatherDataset= new LineDataset<TimeTuple<int>>
        {
            BackgroundColor = ColorUtil.FromDrawingColor(System.Drawing.Color.White),
            BorderColor = ColorUtil.FromDrawingColor(System.Drawing.Color.Red),
            Label = "tempertarure",
            Fill = false,
            BorderWidth = 2,
            PointRadius = 2,
            PointBorderWidth = 2,
            SteppedLine = SteppedLine.False,
            Hidden = false
        };
        
        var chartData = _historicalData.Select
            (_ => new TimeTuple<int>(new Moment(_.Date), System.Convert.ToInt32(Math.Ceiling(_.Temp))));
        _WeatherDataset.AddRange(chartData);
        _config.Data.Datasets.Add(_WeatherDataset);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlQueries SqlQueries { get; set; }
    }
}
#pragma warning restore 1591
