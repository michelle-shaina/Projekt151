#pragma checksum "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b780962afed86ebbeddf4ef3afc1352f68a55350"
// <auto-generated/>
#pragma warning disable 1591
namespace Projekt151.Pages.Add
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
#line 1 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
using Projekt151.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addtask")]
    public partial class AddTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Task</h2>\n<hr>\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
                                                               task.TaskName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.TaskName = __value, task.TaskName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.AddMarkupContent(24, "\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-8");
            __builder.AddMarkupContent(27, "\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "\n                ");
            __builder.AddMarkupContent(31, "<label for=\"Name\" class=\"control-label\">Beschreibung</label>\n                ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "for", "Name");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
                                                               task.Beschreibung

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.Beschreibung = __value, task.Beschreibung));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.AddMarkupContent(43, "\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-md-4");
            __builder.AddMarkupContent(46, "\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-group");
            __builder.AddMarkupContent(49, "\n                ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "class", "btn btn-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
                                                                        CreateTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n                ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "class", "btn");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\miche\source\repos\Projekt151\Projekt151\Projekt151\Pages\Add\AddTask.razor"
        
    Tasks task = new Tasks();

    protected async Task CreateTask()
    {
        await TaskService.CreateTask(task);
        NavigationManager.NavigateTo("listtasks");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listtasks");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ITasksService TaskService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591