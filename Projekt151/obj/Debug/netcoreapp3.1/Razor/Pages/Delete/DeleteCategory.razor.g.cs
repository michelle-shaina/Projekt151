#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277b5f9002ab6ffa848025df616c2c23a9578df3"
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletecategory/{id:int}")]
    public partial class DeleteCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Confirm Delete</h2>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this Category with Id :");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
                                                               id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
#nullable restore
#line 11 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
 if (isUsed)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<label for=\"Hint\" style=\"color: red\" class=\"control-label\">This Category is in use from at least one Project</label>\r\n");
#nullable restore
#line 14 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<td>Name</td>\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 19 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
                 category.KategorieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.AddMarkupContent(24, "<td>Description</td>\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 23 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
                 category.Beschreibung

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "value", "Delete");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
                                                       Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "value", "Cancel");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
                                                       Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "btn");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Delete\DeleteCategory.razor"
        
    [Parameter]
    public int id { get; set; }
    Kategorie category = new Kategorie();
    IEnumerable<ProjectFormatted> projects;
    bool isUsed = false;

    protected override async Task OnInitializedAsync()
    {
        projects = await ProjectService.GetP();
        category = await CategoryService.SingleCategory(id);
    }

    protected async Task Delete()
    {
        foreach (var p in projects)
        {
            if (Convert.ToInt32(p.KategorieId) == id)
            {
                isUsed = true;
            }
        }
        if (!isUsed)
        {
            await CategoryService.DeleteCategory(id);
            NavigationManager.NavigateTo("listcategories");
        }
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listcategories");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IProjektService ProjectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IKategorieService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
