#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77a3b0d690829ba6377bbd506c36082610e36e5"
// <auto-generated/>
#pragma warning disable 1591
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
#line 7 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproject/{id:int}")]
    public partial class EditProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Project</h3>\r\n<hr>\r\n");
#nullable restore
#line 12 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
 if (categories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p> ");
#nullable restore
#line 14 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                           }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label for=\"Name\" class=\"control-label\">Projekt Name</label>\r\n            ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "for", "Name");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                           formattedProject.ProjektName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => formattedProject.ProjektName = __value, formattedProject.ProjektName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-8");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<label for=\"Beschreibung\" class=\"control-label\">Description</label>\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "for", "Beschreibung");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                   formattedProject.Beschreibung

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => formattedProject.Beschreibung = __value, formattedProject.Beschreibung));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-8");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<label for=\"Date\" class=\"control-label\">Sart Date</label>\r\n            <br>\r\n            ");
            __Blazor.Projekt151.Pages.Edit.EditProject.TypeInference.CreateRadzenDatePicker_0(__builder, 42, 43, "d", 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                              args => OnChange(args, "StartPicker", "MM/dd/yyyy HH:mm:ss")

#line default
#line hidden
#nullable disable
            ), 45, 
#nullable restore
#line 34 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                           StartValue

#line default
#line hidden
#nullable disable
            , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => StartValue = __value, StartValue)), 47, () => StartValue);
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-md-8");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "form-group");
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<label for=\"Date\" class=\"control-label\">End Date</label>\r\n            <br>\r\n            ");
            __Blazor.Projekt151.Pages.Edit.EditProject.TypeInference.CreateRadzenDatePicker_1(__builder, 58, 59, "d", 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, 
#nullable restore
#line 41 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                            args => OnChange(args, "EndPicker", "MM/dd/yyyy HH:mm:ss")

#line default
#line hidden
#nullable disable
            ), 61, 
#nullable restore
#line 41 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                           EndValue

#line default
#line hidden
#nullable disable
            , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EndValue = __value, EndValue)), 63, () => EndValue);
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-md-8");
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "form-group");
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.AddMarkupContent(73, "<label for=\"Employees\" class=\"control-label\">Employees</label>\r\n            <br>\r\n            ");
            __Blazor.Projekt151.Pages.Edit.EditProject.TypeInference.CreateRadzenDropDown_2(__builder, 74, 75, 
#nullable restore
#line 48 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                        true

#line default
#line hidden
#nullable disable
            , 76, 
#nullable restore
#line 48 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 77, 
#nullable restore
#line 48 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                                           FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 78, 
#nullable restore
#line 49 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 79, "Select...", 80, 
#nullable restore
#line 50 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                  employees

#line default
#line hidden
#nullable disable
            , 81, "MitarbeiterName", 82, "MitarbeiterId", 83, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 51 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                     args => OnChange(args, "MitarbeiterName")

#line default
#line hidden
#nullable disable
            ), 84, "width:400px", 85, 
#nullable restore
#line 49 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                         mEmployees

#line default
#line hidden
#nullable disable
            , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mEmployees = __value, mEmployees)), 87, () => mEmployees);
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col-md-8");
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form-group");
            __builder.AddMarkupContent(96, "\r\n            ");
            __builder.AddMarkupContent(97, "<label for=\"Tasks\" class=\"control-label\">Tasks</label>\r\n            <br>\r\n            ");
            __Blazor.Projekt151.Pages.Edit.EditProject.TypeInference.CreateRadzenDropDown_3(__builder, 98, 99, 
#nullable restore
#line 59 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                        true

#line default
#line hidden
#nullable disable
            , 100, 
#nullable restore
#line 59 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 101, 
#nullable restore
#line 59 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                                           FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 102, 
#nullable restore
#line 60 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                          true

#line default
#line hidden
#nullable disable
            , 103, "Select...", 104, 
#nullable restore
#line 61 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                  tasks

#line default
#line hidden
#nullable disable
            , 105, "TaskName", 106, "TaskId", 107, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 62 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                     args => OnChange(args, "TaskName")

#line default
#line hidden
#nullable disable
            ), 108, "width:400px", 109, 
#nullable restore
#line 60 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                         mTasks

#line default
#line hidden
#nullable disable
            , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mTasks = __value, mTasks)), 111, () => mTasks);
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-md-8");
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "form-group");
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.AddMarkupContent(121, "<label for=\"Category\" class=\"control-label\">Category</label>\r\n            ");
            __builder.OpenElement(122, "select");
            __builder.AddAttribute(123, "for", "Category");
            __builder.AddAttribute(124, "class", "form-control");
            __builder.AddAttribute(125, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                formattedProject.KategorieId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => formattedProject.KategorieId = __value, formattedProject.KategorieId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(127, "\r\n                ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", true);
            __builder.AddContent(130, "-- Select Category --");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 73 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                 foreach (var category in categories)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "                    ");
            __builder.OpenElement(133, "option");
            __builder.AddAttribute(134, "value", 
#nullable restore
#line 75 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                    category.KategorieId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(135, 
#nullable restore
#line 75 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                           category.KategorieName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                                          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "col-md-6");
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form-group");
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.OpenElement(146, "input");
            __builder.AddAttribute(147, "type", "button");
            __builder.AddAttribute(148, "class", "btn btn-primary");
            __builder.AddAttribute(149, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                                    UpdateProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(150, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.OpenElement(152, "input");
            __builder.AddAttribute(153, "type", "button");
            __builder.AddAttribute(154, "class", "btn");
            __builder.AddAttribute(155, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(156, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n");
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\miche\source\repos\Projekt151\Projekt151\Pages\Edit\EditProject.razor"
        
    [Parameter]
    public int id { get;set; }
    ProjectFormatted formattedProject = new ProjectFormatted();
    IEnumerable<Kategorie> categories;
    IEnumerable<Tasks> tasks;
    IEnumerable<Mitarbeiter> employees;
    List<Tasks> selectedTaks = new List<Tasks>();
    List<Mitarbeiter> selectedEmployees = new List<Mitarbeiter>();
    List<string> employeeNum = new List<string>();
    List<string> tasksNum = new List<string>();
    string taskString = "";
    string employeeString = "";
    DateTime? StartValue;
    DateTime? EndValue;

    IList<string> multipleEmployees = new List<string>();
    IEnumerable<string> mEmployees;
    IList<int> multipleTasks = new List<int>();
    IEnumerable<int> mTasks;

    protected override async Task OnInitializedAsync()
    {
        categories = await CategoryService.GetCategories();
        formattedProject = await ProjectService.SingleProject(id);
        tasks = await TaskService.GetTasks();
        employees = await EmployeeService.GetEmployees();
        mTasks = GetTasks();
        mEmployees = GetEmployees();
        StartValue = DateTime.Parse(formattedProject.StartDate);
        EndValue = DateTime.Parse(formattedProject.EndDate);
    }

    private IEnumerable<string> GetEmployees()
    {
        foreach (var e in formattedProject.Mitarbeiters)
        {
            multipleEmployees.Add(e.MitarbeiterId);
        }
        return multipleEmployees.AsEnumerable<string>();
    }

    private IEnumerable<int> GetTasks()
    {
        foreach (var t in formattedProject.Tasks)
        {
            multipleTasks.Add(t.TaskId);
        }
        return multipleTasks.AsEnumerable<int>();
    }

    public async Task UpdateProject()
    {
        getTasksAndEmployeesSelected();
        formattedProject.IsGoing = true;
        formattedProject.Tasks = selectedTaks;
        formattedProject.Mitarbeiters = selectedEmployees;
        await ProjectService.EditProject(id, formattedProject);
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
        }
        else
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
            employeeString = string.Join(",", ((IEnumerable<string>)value));
        }
        else
        {
            taskString = string.Join(",", ((IEnumerable<int>)value));
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
namespace __Blazor.Projekt151.Pages.Edit.EditProject
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDatePicker_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Change", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDatePicker_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::System.DateTime?> __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDatePicker<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DateFormat", __arg0);
        __builder.AddAttribute(__seq1, "Change", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Radzen.FilterCaseSensitivity __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.IEnumerable __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg8, int __seq9, global::System.String __arg9, int __seq10, global::System.Object __arg10, int __seq11, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg11, int __seq12, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg12)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowClear", __arg0);
        __builder.AddAttribute(__seq1, "AllowFiltering", __arg1);
        __builder.AddAttribute(__seq2, "FilterCaseSensitivity", __arg2);
        __builder.AddAttribute(__seq3, "Multiple", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "TextProperty", __arg6);
        __builder.AddAttribute(__seq7, "ValueProperty", __arg7);
        __builder.AddAttribute(__seq8, "Change", __arg8);
        __builder.AddAttribute(__seq9, "Style", __arg9);
        __builder.AddAttribute(__seq10, "Value", __arg10);
        __builder.AddAttribute(__seq11, "ValueChanged", __arg11);
        __builder.AddAttribute(__seq12, "ValueExpression", __arg12);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::Radzen.FilterCaseSensitivity __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.IEnumerable __arg5, int __seq6, global::System.String __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg8, int __seq9, global::System.String __arg9, int __seq10, global::System.Object __arg10, int __seq11, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg11, int __seq12, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg12)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "AllowClear", __arg0);
        __builder.AddAttribute(__seq1, "AllowFiltering", __arg1);
        __builder.AddAttribute(__seq2, "FilterCaseSensitivity", __arg2);
        __builder.AddAttribute(__seq3, "Multiple", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "TextProperty", __arg6);
        __builder.AddAttribute(__seq7, "ValueProperty", __arg7);
        __builder.AddAttribute(__seq8, "Change", __arg8);
        __builder.AddAttribute(__seq9, "Style", __arg9);
        __builder.AddAttribute(__seq10, "Value", __arg10);
        __builder.AddAttribute(__seq11, "ValueChanged", __arg11);
        __builder.AddAttribute(__seq12, "ValueExpression", __arg12);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591