#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1192f3c91685172fadb8fa8972f063133f54939"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Pages.Add
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addemployee")]
    public partial class AddMitarbeiter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Employee</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                               employee.MitarbeiterName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.MitarbeiterName = __value, employee.MitarbeiterName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"City\" class=\"control-label\">City</label>\r\n                ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "for", "City");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                                employee.StadtId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.StadtId = __value, employee.StadtId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", true);
            __builder.AddContent(32, "-- Select City --");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 21 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                     foreach (var city in cities)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "        ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 23 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                        city.StadtId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, 
#nullable restore
#line 23 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                       city.StadtName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 24 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label for=\"City\" class=\"control-label\">Role</label>\r\n                ");
            __builder.OpenElement(46, "select");
            __builder.AddAttribute(47, "for", "City");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                                employee.RoleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.RoleId = __value, employee.RoleId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "option");
            __builder.AddAttribute(53, "value", true);
            __builder.AddContent(54, "-- Select Role --");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 31 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                     foreach (var role in roles)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.OpenElement(57, "option");
            __builder.AddAttribute(58, "value", 
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                        role.RoleId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, 
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                      role.RoleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.AddMarkupContent(67, "<label for=\"Password\" class=\"control-label\">Password</label>\r\n                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "for", "Password");
            __builder.AddAttribute(70, "type", "password");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                                                   employee.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Password = __value, employee.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row");
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-md-4");
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "form-group");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "type", "button");
            __builder.AddAttribute(89, "class", "btn btn-primary");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                                        CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "button");
            __builder.AddAttribute(95, "class", "btn");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddMitarbeiter.razor"
       
    Mitarbeiter employee = new Mitarbeiter();
    IEnumerable<Role> roles = new List<Role>();
    IEnumerable<Stadt> cities = new List<Stadt>();

    protected override async Task OnInitializedAsync()
    {
        cities = await CityService.GetCities();
        roles = await RoleService.GetRoles();
    }

    protected async Task CreateEmployee()
    {
        await EmployeeService.CreateEmployee(employee);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IStadtService CityService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
