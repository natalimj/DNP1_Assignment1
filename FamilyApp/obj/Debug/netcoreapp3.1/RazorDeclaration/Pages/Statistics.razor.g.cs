#pragma checksum "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d34458cc45f5379ebbb9087982b4b3089e9cd477"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FamilyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using FamilyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using FamilyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\Statistics.razor"
      

    static int ChildMale;
    static int ChildFemale;
    static int AdultMale;
    static int AdultFemale;
    
    protected override async Task OnInitializedAsync()
    {
        AdultFemale = MemberService.GetAdults().Where(a => a.Sex.Equals("F")).ToList().Count;
        ChildFemale=MemberService.GetChildren().Where(c => c.Sex.Equals("F")).ToList().Count;
        AdultMale = MemberService.GetAdults().Where(a => a.Sex.Equals("M")).ToList().Count;
        ChildMale=MemberService.GetChildren().Where(c => c.Sex.Equals("M")).ToList().Count;
        StateHasChanged();
    }
    
    public class BarChartData
    {
        public string x { get; set; }
        public int y { get; set; }
        public int y1 { get; set; }
    }

    
    public List<BarChartData> GenderData =  new List<BarChartData>
    {
        new BarChartData { x= "Adults",  y= AdultFemale , y1= AdultMale },
        new BarChartData { x= "Children",  y= ChildFemale , y1= ChildFemale },
      
    };
    string CurrentUri;
    void ChartLoad(ILoadedEventArgs Args)
    {
        CurrentUri = NavigationManager.Uri;
        Args.Theme = ChartTheme.Bootstrap4;
        
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591