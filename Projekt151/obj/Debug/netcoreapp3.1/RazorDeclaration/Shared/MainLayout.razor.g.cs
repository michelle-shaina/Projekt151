#pragma checksum "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f437c26c7b5dc23b3d8003d2b238a05c2b8f06d7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Projekt151.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Projekt151;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Projekt151.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\Shared\MainLayout.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\miche\source\repos\Projekt151-master\Projekt151-master\Projekt151\Projekt151\Shared\MainLayout.razor"
       
    private string Username { get; set; }
    private string Password { get; set; }
    private bool isLoginValid = false;

    IEnumerable<MitarbeiterModel> employees;
    MitarbeiterModel employee = new MitarbeiterModel();
    Role role = new Role();

    protected override async Task OnInitializedAsync()
    {
        employees = await EmployeeService.GetEmployees();
    }
    protected async Task UpdateRole()
    {
        await RoleService.EditRole(1, role);
    }

    void doClick()
    {
        foreach (var e in employees)
        {
            if (e.MitarbeiterName == Username && e.Password == Password)
            {
                role.RoleName = Username;
                UpdateRole();
                isLoginValid = true;
                NavigationManager.NavigateTo("/");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IRoleService RoleService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
