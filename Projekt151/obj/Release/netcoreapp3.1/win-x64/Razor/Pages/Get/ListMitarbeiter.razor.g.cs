#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f298d45f128c19a5648d1c5f24dfb04d4bb9fd"
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listemployees")]
    public partial class ListMitarbeiter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Employee Details</h2>\r\n");
#nullable restore
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
 if (loginState.role.Equals("Admin"))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addemployee\">Create New Employee</a>\r\n</p>\r\n");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
 if (employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p> ");
#nullable restore
#line 15 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
                           }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>City</th>\r\n            <th>Role</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
         foreach (var employee in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
         employee.MitarbeiterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
         employee.NameStadt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
         employee.RoleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
         if (loginState.role.Equals("Admin"))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "/editemployee/" + (
#nullable restore
#line 36 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
                        employee.MitarbeiterId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<span>|</span>\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "style", "color: red");
            __builder.AddAttribute(29, "href", "/deleteemployee/" + (
#nullable restore
#line 38 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
                                                                     employee.MitarbeiterId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Delete");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
                                                                                                       }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 41 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListMitarbeiter.razor"
        IEnumerable<MitarbeiterModel> employees;
    protected override async Task OnInitializedAsync()
    {
        employees = await EmployeeService.GetEmployees();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
