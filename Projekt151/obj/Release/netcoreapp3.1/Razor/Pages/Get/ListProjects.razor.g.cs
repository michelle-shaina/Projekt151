#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99fb60054bbb3975f878d08516456669d4c57bfa"
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listprojects")]
    public partial class ListProjects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Project Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addprojects\">Create New Project</a>\r\n</p>\r\n");
#nullable restore
#line 10 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
 if (pro == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p> ");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                               }
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
     foreach (var p in pro)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddAttribute(7, "style", "width: 18rem;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "card-title");
            __builder.AddContent(14, 
#nullable restore
#line 19 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                    p.ProjektName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h6");
            __builder.AddAttribute(17, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                                       p.Beschreibung

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "class", "table");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<thead>\r\n                    <tr>\r\n                        <th>Tasks</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(24, "tbody");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 28 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                     foreach (var t in p.Tasks)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                    ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.AddContent(31, 
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                         t.TaskName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.AddMarkupContent(41, "<thead>\r\n                    <tr>\r\n                        <th>Mitarbeiter</th>\r\n                    </tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(42, "tbody");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 45 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                     foreach (var m in p.Mitarbeiters)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                        ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 48 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                 m.MitarbeiterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 50 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.AddMarkupContent(54, "<a href=\"#\" class=\"card-link\">Card link</a>\r\n            ");
            __builder.AddMarkupContent(55, "<a href=\"#\" class=\"card-link\">Another link</a>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 57 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
       
    IEnumerable<ProjectFormatted> pro;
    Role role = new Role();

    protected override async Task OnInitializedAsync()
    {
        role = await RoleService.SingleRole(1);
        pro = await ProjectService.GetP();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IProjektService ProjectService { get; set; }
    }
}
#pragma warning restore 1591
