// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SMA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using SMA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using SMA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\_Imports.razor"
using MudBlazor;

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
#line 6 "c:\Users\thammyryscampos\Downloads\TrabBrunaThammyrys\SMA\Pages\Index.razor"
       
    public List<ChartSeries> Series = new List<ChartSeries>();
    public ChartOptions Options = new ChartOptions();
    public string[] XAxisLabels = { "2016", "2017", "2018", "2019", "2020", "2021", "2022" };
    protected override void OnInitialized()
    {
        double[] Data1 = { 65, 68, 70, 74, 74, 72, 74 };
        double[] Data2 = { 88, 90, 91, 92, 91, 90, 90 };
        double[] Data3 = { 89, 91, 92, 92, 92, 92, 91 };
        double[] Data4 = { 85, 86, 90, 90, 92, 99, 0 };


        Series.Add(new ChartSeries() { Name = "Produtos", Data = Data1 });
        Series.Add(new ChartSeries() { Name = "Produtos consertados", Data = Data2 });
        Series.Add(new ChartSeries() { Name = "Fluxo", Data = Data3 });
        Series.Add(new ChartSeries() { Name = "Perda total", Data = Data4 });

        Options.YAxisTicks = 400;

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
