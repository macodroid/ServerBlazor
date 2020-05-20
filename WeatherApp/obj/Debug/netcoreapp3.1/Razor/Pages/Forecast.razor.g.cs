#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5860ef8b9bb8bf1fc4e8246176f3039ab60789ca"
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
#line 2 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
using WeatherDataAccessLibrary;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/forecast")]
    public partial class Forecast : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Forecast.razor"
      


    protected override void OnInitialized()
    {
        DatabaseNotifications.ReceiveNotifyCurrentWeather();
        DatabaseNotifications.OnForecastChange += SqlDataAccessOnForecastChange;
    }

    private void SqlDataAccessOnForecastChange(object? sender, ForecastResponseModel e)
    {
        throw new NotImplementedException();
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
