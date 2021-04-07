#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67eaede2f62cfb98f06416256037726bec7a9e7"
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
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Projekt151;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Projekt151.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
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
            __builder.AddMarkupContent(0, "<h2>City Details</h2>\n");
            __builder.AddMarkupContent(1, "<p>\n    <a href=\"/addcity\">Create New City</a>\n</p>\n\n");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
 if (cities == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p> ");
#nullable restore
#line 14 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.AddMarkupContent(6, "<thead>\n        <tr>\n            <th>Name</th>\n            <th>State</th>\n        </tr>\n    </thead>\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 25 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         foreach (var city in cities)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 28 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         city.StadtName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 30 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
         if (role.RoleName == "Admin")
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/editcity/" + (
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                                city.StadtId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                                    ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/deletecity/" + (
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                                                          city.StadtId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListCities.razor"
        IEnumerable<Stadt> cities;
    Role role = new Role();
            protected override async Task OnInitializedAsync()
            {
        role = await RoleService.SingleRole(1);
                cities = await StadtService.GetCities();
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IStadtService StadtService { get; set; }
    }
}
#pragma warning restore 1591
