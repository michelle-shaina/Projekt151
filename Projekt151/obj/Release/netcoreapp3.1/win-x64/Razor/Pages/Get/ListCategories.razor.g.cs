#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12762da1a45f44316e132c2d615497e8977d3ea7"
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
#line 3 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listcategories")]
    public partial class ListCategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Categories Details</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addcategory\">Create New Category</a>\r\n</p>\r\n");
#nullable restore
#line 10 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p> ");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
                           }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Description</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 23 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
         foreach (var category in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 26 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
         category.KategorieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
         category.Beschreibung

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "td");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 29 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
         if (loginState.role.Equals("Admin"))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "/editcategory/" + (
#nullable restore
#line 31 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
                        category.KategorieId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<span>|</span>\r\n                        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "style", "color: red");
            __builder.AddAttribute(26, "href", "/deletecategory/" + (
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
                                                                     category.KategorieId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete");
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
                                                                                                     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Get\ListCategories.razor"
        IEnumerable<Kategorie> categories;

    protected override async Task OnInitializedAsync()
    {
        categories = await CategoryService.GetCategories();
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Data.LoginState loginState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IKategorieService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
