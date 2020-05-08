#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2975627ba56802b63fd3d13167f8c334a98f7c0d"
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
using Interfaces.WeatherDataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
using WeatherApp.Common.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather Forecast for Bratislava</h1>\n");
#nullable restore
#line 11 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
 if (_weatherData == null) 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h4>Loading...</h4>\n");
#nullable restore
#line 14 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<thead>\n        <tr>\n            <th>Date</th>\n            <th>Temperature</th>\n            <th>Pressure</th>\n            <th>Humidity</th>\n        </tr>\n        </thead>\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 27 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
         foreach (var data in _weatherData)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                     data.Date.ToString("HH")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, ":00");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                     Math.Ceiling(data.Temp)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "&deg");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                     data.Pressure

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " (mmHg)");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
                     data.Humidity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, "%");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 35 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 38 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
 

    private List<WeatherModel> _weatherData;

    protected override async Task OnInitializedAsync()
    {
        _weatherData = await SqlQueries.GetTodayWeather();
        SqlDataAccess.ReceiveNotify();
        SqlDataAccess.OnWeatherChange += SqlDataAccessOnOnWeatherChange;
    }

    private async void SqlDataAccessOnOnWeatherChange(object? sender, WeatherModel e)
    {
        _weatherData.Add(e);
        
        await InvokeAsync(() =>
        {
            base.StateHasChanged();
        });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlQueries SqlQueries { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISqlDataAccess SqlDataAccess { get; set; }
    }
}
#pragma warning restore 1591