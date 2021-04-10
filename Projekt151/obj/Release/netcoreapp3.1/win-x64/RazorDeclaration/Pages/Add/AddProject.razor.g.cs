#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f937b32c6ba8fe1695c0d6149124b689ff81dbd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddProject.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addprojects")]
    public partial class AddProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Add\AddProject.razor"
       
    object employeeIds;
    object tasksIds;
    ProjectFormatted formattedProject = new ProjectFormatted();
    IEnumerable<MitarbeiterModel> employees;
    IEnumerable<Kategorie> categories;
    IEnumerable<Tasks> tasks;
    List<Tasks> selectedTaks = new List<Tasks>();
    List<Mitarbeiter> selectedEmployees = new List<Mitarbeiter>();
    List<string> employeeNum = new List<string>();
    List<string> tasksNum = new List<string>();
    string taskString = "";
    string employeeString = "";
    DateTime? StartDate = DateTime.Now;
    DateTime? EndDate = DateTime.Now;

    protected override async Task OnInitializedAsync()
    {
        employees = await EmployeeService.GetEmployees();
        categories = await CategoryService.GetCategories();
        tasks = await TaskService.GetTasks();
    }

    public async Task CreateProject()
    {
        getTasksAndEmployeesSelected();
        formattedProject.IsGoing = true;
        formattedProject.Tasks = selectedTaks;
        formattedProject.Mitarbeiters = selectedEmployees;
        await ProjectService.CreateProjects(formattedProject);
        NavigationManager.NavigateTo("listprojects");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listprojects");
    }

    void OnChange(DateTime? value, string name, string format)
    {
        if (name == "StartPicker")
        {
            formattedProject.StartDate = value?.ToString(format);
        } else
        {
            formattedProject.EndDate = value?.ToString(format);
        }
    }

    void getTasksAndEmployeesSelected()
    {
        foreach (var t in tasksNum)
        {
            foreach (var ta in tasks)
            {
                if (t == ta.TaskId.ToString())
                {
                    selectedTaks.Add(ta);
                }
            }
        }
        foreach (var e in employeeNum)
        {
            foreach (var em in employees)
            {
                if (e == em.MitarbeiterId.ToString())
                {
                    selectedEmployees.Add(em);
                }
            }
        }
    }

    void OnChange(object value, string name)
    {
        if (name == "MitarbeiterName")
        {
            employeeString = string.Join(",", ((IEnumerable<string>)employeeIds));
        } else
        {
            taskString = string.Join(",", ((IEnumerable<int>)tasksIds));
        }
        employeeNum = employeeString.Split(",").ToList();
        tasksNum = taskString.Split(",").ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ITasksService TaskService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IKategorieService CategoryService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IMitarbeiterService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IProjektService ProjectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591