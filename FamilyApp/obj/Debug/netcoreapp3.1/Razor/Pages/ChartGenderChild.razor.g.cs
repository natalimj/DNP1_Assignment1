#pragma checksum "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "384abda2ef825b3bf38562f6342271fa7bb357b2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PieChartChild")]
    public partial class ChartGenderChild : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-8 control-section");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "control-section");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(9);
            __builder.AddAttribute(10, "Title", "Children");
            __builder.AddAttribute(11, "EnableAnimation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartEvents>(14);
                __builder2.AddAttribute(15, "Load", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Charts.IAccLoadedEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                           BeforeRender

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartTooltipSettings>(17);
                __builder2.AddAttribute(18, "Enable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(20);
                __builder2.AddAttribute(21, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(23);
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(25, "\r\n                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(26);
                    __builder3.AddAttribute(27, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                          dataSource

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "XName", "xValue");
                    __builder3.AddAttribute(29, "YName", "yValue");
                    __builder3.AddAttribute(30, "Name", "Browser");
                    __builder3.AddAttribute(31, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                                                            OuterRadius

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "StartAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                                                                                      StartAngle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "EndAngle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 14 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                                                                                                             EndAngle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "InnerRadius", "0%");
                    __builder3.AddAttribute(35, "ExplodeIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 15 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                             ExplodeIndex

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "Explode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ExplodeOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                                                          ExplodeRadius

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(39, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(40);
                        __builder4.AddAttribute(41, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(42, "Name", "xValue");
                        __builder4.AddAttribute(43, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.AccumulationLabelPosition>(
#nullable restore
#line 16 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
                                                                                              AccumulationLabelPosition.Outside

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\ChartGenderChild.razor"
      
    public int StartAngle = 0, value = 0, EndAngle = 360, radiusValue = 70, exploderadius = 10;
    public double ExplodeIndex = 1;
    public string OuterRadius = "70%", ExplodeRadius = "0%";
    public static int NumberOfFemales;
    public static int NumberOfMales;
 
    public class PieData1
    {
        public string xValue { get; set; }
        public double yValue { get; set; }

    }
    private List<PieData1> dataSource = new List<PieData1>
  {
        new PieData1 { xValue = "Male", yValue =NumberOfMales},
        new PieData1 { xValue = "Female",    yValue = NumberOfFemales},
        
    };
    
    string CurrentUri;
    void BeforeRender(IAccLoadedEventArgs Args)
    {
        CurrentUri = NavigationManager.Uri;
        Args.Theme = AccumulationTheme.Bootstrap;
        SetValues();
    }

    void SetValues()
    {
        NumberOfFemales = MemberService.GetChildren().Where(c => c.Sex.Equals("F")).ToList().Count;
        NumberOfMales = MemberService.GetChildren().Where(c => c.Sex.Equals("M")).ToList().Count;

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
