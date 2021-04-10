#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef3c568d6c1731cac985f09e58d34d93dacce1a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Pages.Get
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Projekt151;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Projekt151.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\miche\source\repos\Projekt151\Projekt151\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcities")]
    public partial class ListCities : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>City Details</h2>\r\n");
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
 if (loginState.role.Equals("Admin"))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        <a href=\"/addcity\">Create New City</a>\r\n    </p>\r\n");
#nullable restore
#line 13 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 15 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
 if (cities == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p> ");
#nullable restore
#line 17 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                           }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 28 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         foreach (var city in cities)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         city.StadtName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         if (loginState.role.Equals("Admin"))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "/editcity/" + (
#nullable restore
#line 35 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                    city.StadtId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<span>|</span>\r\n                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "style", "color: red");
            __builder.AddAttribute(25, "href", "/deletecity/" + (
#nullable restore
#line 37 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                                                                 city.StadtId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Delete");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                                                                                         }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCities.razor"
        IEnumerable<Stadt> cities;
    protected override async Task OnInitializedAsync()
    {
        cities = await StadtService.GetCities();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IStadtService StadtService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LoginState loginState { get; set; }
    }
}
#pragma warning restore 1591
