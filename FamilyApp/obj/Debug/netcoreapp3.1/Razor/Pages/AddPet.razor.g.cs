#pragma checksum "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22352e98896c24c3f617e4762b3a2d268e7f86da"
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
#line 3 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
using FamilyApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
using FamilyApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPet")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPet/{Id:int}")]
    public partial class AddPet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Pet</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                  newPet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                                          AddNewPet

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n    Name<br>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                            newPet.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Name = __value, newPet.Name))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newPet.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "\r\n                    Age<br>\r\n                    ");
                __Blazor.FamilyApp.Pages.AddPet.TypeInference.CreateInputNumber_0(__builder2, 22, 23, 
#nullable restore
#line 19 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                                              newPet.Age

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Age = __value, newPet.Age)), 25, () => newPet.Age);
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n                   ");
                __Blazor.FamilyApp.Pages.AddPet.TypeInference.CreateInputSelect_1(__builder2, 31, 32, "form-control", 33, "species", 34, "width:200px", 35, 
#nullable restore
#line 22 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                                                                                newPet.Species

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newPet.Species = __value, newPet.Species)), 37, () => newPet.Species, 38, (__builder3) => {
                    __builder3.AddMarkupContent(39, "\r\n                       ");
                    __builder3.AddMarkupContent(40, "<option value=\"species\" selected disabled>Species</option>  \r\n");
#nullable restore
#line 24 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                        foreach (var sp in species)
                       {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(41, "                           ");
                    __builder3.OpenElement(42, "option");
                    __builder3.AddAttribute(43, "value", 
#nullable restore
#line 26 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                                           sp

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(44, 
#nullable restore
#line 26 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                                                sp

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 27 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
                       }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(46, "        \r\n                   ");
                }
                );
                __builder2.AddMarkupContent(47, "\r\n                   \r\n                                      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.AddMarkupContent(49, "<p class=\"actions\">\r\n                <button class=\"btn btn-outline-dark\" type=\"submit\">Add</button>\r\n            </p>\r\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\natal\RiderProjects\Assignment1_Approach2\FamilyApp\Pages\AddPet.razor"
       
        
    [Parameter]
    public int Id { get; set; }
    public Family Family { get; set; }
    private Pet newPet=new Pet();
    
        
    protected override async Task OnInitializedAsync() {
        if (Id != 0)
        {
            Family = FamilyService.GetFamilies().First(f => f.Id == Id);

        }
    }
    
    private void AddNewPet()
    {
        MemberService.AddPet(newPet);
        FamilyService.AddPetToFamily(Family,newPet);
        NavigationManager.NavigateTo("Success/" + Family.Id);
        
    }
    
    List<string> species = new[] {"Hamster", "Bunny", "Frog", "Budgerigar","Owl", "Snake", "Cat", "Dog", "None"}.ToList();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMemberService MemberService { get; set; }
    }
}
namespace __Blazor.FamilyApp.Pages.AddPet
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
