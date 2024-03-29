#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a2061ee63278539b0f30575c3228dd21bda45d0"
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
#line 3 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
using WeatherApp.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
using WeatherDataAccessLibrary.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    table.table{\n        text-align: center;\n        width: 70%;\n        margin: 0 auto;\n        margin-top: 40px;\n    }\n    h1.actualWeatherH1{\n        text-align: center;\n        margin-top: 20px;\n    }\n</style>\n\n\n");
            __builder.AddMarkupContent(1, "<h1 class=\"actualWeatherH1\">Aktualne počasie pre mesto Bratislava</h1>\n");
#nullable restore
#line 25 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
 if (_weatherData == null) 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<h4>Načitávanie...</h4>\n");
#nullable restore
#line 28 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, @"<thead>
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
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 45 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
         foreach (var data in _weatherData)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "style", "vertical-align: middle");
            __builder.AddContent(16, 
#nullable restore
#line 48 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    data.Date.ToString("HH:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "style", "vertical-align: middle");
            __builder.AddContent(20, 
#nullable restore
#line 49 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    Math.Ceiling(data.Temp)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, "&deg");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "vertical-align: middle");
            __builder.AddContent(25, 
#nullable restore
#line 50 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    Math.Ceiling(data.Feels_Like)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, "&deg");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "style", "vertical-align: middle");
            __builder.AddContent(30, 
#nullable restore
#line 51 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    data.Pressure

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " (mmHg)");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "style", "vertical-align: middle");
            __builder.AddContent(35, 
#nullable restore
#line 52 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    data.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "style", "vertical-align: middle");
            __builder.AddMarkupContent(40, "\n                    ");
            __builder.OpenElement(41, "img");
            __builder.AddAttribute(42, "src", "http://openweathermap.org/img/wn/" + (
#nullable restore
#line 54 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                                data.Icon.Trim()

#line default
#line hidden
#nullable disable
            ) + "@" + "2x.png");
            __builder.AddAttribute(43, "alt", "icon of weather condition");
            __builder.AddAttribute(44, "height", "50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "style", "vertical-align: middle");
            __builder.AddContent(49, 
#nullable restore
#line 56 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    data.Condition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "style", "vertical-align: middle");
            __builder.AddContent(53, 
#nullable restore
#line 57 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                                                    data.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
#nullable restore
#line 59 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 62 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
 
    private List<WeatherModel> _weatherData;

    protected override async Task OnInitializedAsync()
    {
        _weatherData = await SqlQueries.GetTodayWeather();
        DatabaseNotifications.ReceiveNotifyCurrentWeather();
        DatabaseNotifications.OnWeatherChange += SqlDataAccessOnWeatherChange;
    }

    private async void SqlDataAccessOnWeatherChange(object? sender, WeatherModel e)
    {
        CheckIfSameDay(e.Date);
        _weatherData.Add(e);
        
        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
    }
    
    private void CheckIfSameDay(DateTime date)
    {
        var lastItem = _weatherData.LastOrDefault();
        if (lastItem != null && lastItem.Date.Day != date.Day)
        {
            _weatherData = new List<WeatherModel>();
        }
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
