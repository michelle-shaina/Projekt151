#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a256b7710ba203eb7c4059558dd94b219f3ba367"
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
            __builder.AddMarkupContent(0, "<h2>Project Details</h2>\n");
            __builder.AddMarkupContent(1, "<p>\n    <a href=\"/addprojects\">Create New Project</a>\n</p>\n");
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
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 17 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
         foreach (var p in pro)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "            <span></span>\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "classs", "col-sm");
            __builder.AddMarkupContent(13, "\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card");
            __builder.AddAttribute(16, "style", "width: 18rem;");
            __builder.AddMarkupContent(17, "\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "h5");
            __builder.AddAttribute(22, "class", "card-title");
            __builder.AddContent(23, 
#nullable restore
#line 23 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                    p.ProjektName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "h6");
            __builder.AddAttribute(26, "class", "card-subtitle mb-2 text-muted");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                                       p.Beschreibung

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table");
            __builder.AddMarkupContent(31, "\n                ");
            __builder.AddMarkupContent(32, "<thead>\n                    <tr>\n                        <th>Tasks</th>\n                    </tr>\n                </thead>\n                ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                     foreach (var t in p.Tasks)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\n            ");
            __builder.OpenElement(38, "td");
            __builder.AddMarkupContent(39, "\n                ");
            __builder.AddContent(40, 
#nullable restore
#line 36 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                 t.TaskName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#nullable restore
#line 39 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n            ");
            __builder.OpenElement(47, "table");
            __builder.AddAttribute(48, "class", "table");
            __builder.AddMarkupContent(49, "\n                ");
            __builder.AddMarkupContent(50, "<thead>\n                    <tr>\n                        <th>Empoloyees</th>\n                    </tr>\n                </thead>\n                ");
            __builder.OpenElement(51, "tbody");
            __builder.AddMarkupContent(52, "\n");
#nullable restore
#line 49 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                     foreach (var m in p.Mitarbeiters)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(53, "        ");
            __builder.OpenElement(54, "tr");
            __builder.AddMarkupContent(55, "\n            ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 52 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                 m.MitarbeiterName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
#nullable restore
#line 54 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n");
#nullable restore
#line 57 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
             if (role.RoleName == "Admin")
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "href", "deleteproject/" + (
#nullable restore
#line 59 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                        p.ProjektId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "card-link");
            __builder.AddContent(67, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                                        ");
            __builder.OpenElement(69, "a");
            __builder.AddAttribute(70, "href", "/editproject/" + (
#nullable restore
#line 60 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
                                                               p.ProjektId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "class", "card-link");
            __builder.AddContent(72, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n");
#nullable restore
#line 61 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n");
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n");
#nullable restore
#line 67 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Get\ListProjects.razor"
       
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
