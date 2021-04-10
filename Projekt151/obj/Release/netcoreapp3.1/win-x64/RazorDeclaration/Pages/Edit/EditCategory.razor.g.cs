#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b9669566e742c178f6ced48dcfceb7beb4e9c0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Projekt151.Pages.Edit
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
#line 2 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditCategory.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcategory/{id:int}")]
    public partial class EditCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditCategory.razor"
        
    [Parameter]
    public int id { get; set; }
    Kategorie kategorie = new Kategorie();
        
    protected override async Task OnInitializedAsync()
    {
        kategorie = await CategoryService.SingleCategory(id);
    }

    protected async Task UpdateCategory()
    {
        await CategoryService.EditCategory(id, kategorie);
        NavigationManager.NavigateTo("listcategories");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listcategories");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IKategorieService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
