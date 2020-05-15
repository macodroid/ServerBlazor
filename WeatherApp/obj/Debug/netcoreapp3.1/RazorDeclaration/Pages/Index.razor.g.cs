#pragma checksum "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec7851b7d48a47aa0ec40d1a0614bd4b31b154e5"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "/home/maco/Documents/Project/ServerBlazor/WeatherApp/Pages/Index.razor"
 

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
