#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ded84d6832aa34c5010fb3d49ec8f637f65e72b"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Shared
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
#line 5 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
 if (loginState.IsLoggedIn.Equals(false))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h1 style=\"text-align:center\">Login</h1>\r\n");
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "form");
            __builder.AddAttribute(4, "style", "width: 40%; margin: auto");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "text-align:center");
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
#line 16 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
                                                                    username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "text-align:center");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<label for=\"Password\" class=\"control-label\">Password</label>\r\n                ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "for", "Password");
            __builder.AddAttribute(30, "type", "password");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
                                                                                        password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "style", "text-align:center");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "submit");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
                                                                 HandleLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 29 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
            
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
       
    IEnumerable<MitarbeiterModel> employees;
    string username = "";
    string password = "";
    string correctPassword = "Snail";

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
#line 54 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
         foreach (var e in employees)
        {
            if (password == e.Password && username == e.MitarbeiterName)
            {
                loginState.SetLogin(true, username, e.RoleName);
                navigate.NavigateTo("listprojects");
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Shared\Login.razor"
         
    }
    //void HandleLogout()
    //{
    //    username = "";
    //    password = "";
    //    loginState.SetLogin(false, "", "");
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LoginState loginState { get; set; }
    }
}
#pragma warning restore 1591
