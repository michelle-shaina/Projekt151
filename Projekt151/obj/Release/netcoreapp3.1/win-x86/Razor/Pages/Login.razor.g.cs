#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed49f095a65a01fd8118cf496cfd1fdba7f54165"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Pages
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
#line 5 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
 if (loginState.IsLoggedIn.Equals(false))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1 style=\"text-align:center\">Login</h1>\r\n");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
     if (!doesExist)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<p style=\"color: red; text-align:center\">There is no combination of the user and password found, please check the spelling an try again!</p>\r\n");
#nullable restore
#line 15 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "style", "width: 40%; margin: auto");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", "text-align:center");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form-group");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<label aria-label=\"Name\" for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "aria-label", "Password");
            __builder.AddAttribute(17, "for", "Name");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
                                                                                          username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "text-align:center");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group");
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<label for=\"Password\" class=\"control-label\">Password</label>\r\n                ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "for", "Password");
            __builder.AddAttribute(33, "type", "password");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
                                                                                        password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "text-align:center");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "submit");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
                                                                 HandleLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
       
    IEnumerable<MitarbeiterModel> employees;
    string username = "";
    string password = "";
    bool doesExist = true;

    protected override async Task OnInitializedAsync()
    {
        employees = await EmployeeService.GetEmployees();
    }

    void HandleLogin()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
         foreach (var e in employees)
        {
            if (password == e.Password && username == e.MitarbeiterName)
            {
                loginState.SetLogin(true, username, e.RoleName);
                navigate.NavigateTo("listprojects");
            } else
            {
                doesExist = false;
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Login.razor"
         
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LoginState loginState { get; set; }
    }
}
#pragma warning restore 1591
