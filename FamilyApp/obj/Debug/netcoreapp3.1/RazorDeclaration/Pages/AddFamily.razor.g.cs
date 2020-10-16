#pragma checksum "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc753d21bf4dd1272b6ebfd4488eed6b18f7ed11"
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
#line 2 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddFamily.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddFamily.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddFamily")]
    public partial class AddFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddFamily.razor"
       
    private Family newFamily=new Family();
    private String errorMessage;

    private void AddNewFamily()
    {
        errorMessage = "";
        try
        {
            
            FamilyService.AddFamily(newFamily);
        
            NavigationManager.NavigateTo("FamilyPage/" + newFamily.Id);
           
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
            newFamily.FamilyName = "";
            newFamily.StreetName = " ";
            newFamily.HouseNumber = 0;

        }
        
        
        
        
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
