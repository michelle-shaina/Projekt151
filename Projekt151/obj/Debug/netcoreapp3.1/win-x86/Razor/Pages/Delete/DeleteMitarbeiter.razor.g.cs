#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b9f76ff4c3f8c6aea389827c5acf78cf66eb452"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Pages.Delete
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deleteemployee/{id:int}")]
    public partial class DeleteMitarbeiter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Confirm Delete</h2>\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this Employee with Id :");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
                                                               id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n<br>\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\n            ");
            __builder.AddMarkupContent(15, "<td>Name</td>\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
                 employee.MitarbeiterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\n            ");
            __builder.AddMarkupContent(22, "<td>City</td>\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 17 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
                 employee.NameStadt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "value", "Delete");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
                                                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "value", "Cancel");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Delete\DeleteMitarbeiter.razor"
       

    [Parameter]
    public int id { get; set; }
    MitarbeiterModel employee = new MitarbeiterModel();

    protected override async Task OnInitializedAsync()
    {
        employee = await EmployeeService.SingleEmployee(id);
    }

    protected async Task Delete()
    {
        await EmployeeService.DeleteEmployee(id);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
