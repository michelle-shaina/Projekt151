#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ccf76b2ed00a3323115306d1d714543cfeeecb"
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
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listroles")]
    public partial class ListRoles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Role Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addrole\">Create New Role</a>\r\n</p>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
 if (roles == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p> ");
#nullable restore
#line 13 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
                           }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 24 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
         foreach (var role in roles)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
         role.RoleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "/editrole/" + (
#nullable restore
#line 29 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
                            role.RoleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<span>|</span>\r\n        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "style", "color: red");
            __builder.AddAttribute(23, "href", "/deleterole/" + (
#nullable restore
#line 31 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
                                                 role.RoleId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListRoles.razor"
        IEnumerable<Role> roles;
            protected override async Task OnInitializedAsync()
            {
                roles = await RoleService.GetRoles();
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRoleService RoleService { get; set; }
    }
}
#pragma warning restore 1591
