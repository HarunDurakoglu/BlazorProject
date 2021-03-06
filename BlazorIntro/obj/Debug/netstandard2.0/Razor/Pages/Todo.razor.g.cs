#pragma checksum "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3627bf148262151d933110cd14d2c2662e0172db"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorIntro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#line 7 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
using BlazorIntro.Models;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
using BlazorIntro.Services;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todo</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Todo List</h1>\r\n");
#line 9 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
 if (todoItems == null)
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>Loading...</p>\r\n");
#line 12 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>User Id</th>\r\n                <th>Id</th>\r\n                <th>Title (F)</th>\r\n                <th>Completed</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#line 25 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
             foreach (var todoItem in todoItems)
            {

#line default
#line hidden
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#line 28 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
                         todoItem.UserId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#line 29 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
                         todoItem.Id

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 30 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
                         todoItem.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 31 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
                         todoItem.Completed

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#line 33 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
            }

#line default
#line hidden
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 36 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 38 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Todo.razor"
       

    TodoItem[] todoItems;

    protected override async Task OnInitializedAsync()
    {
        
        todoItems = await Api.GetTodos();
    }

    



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiService Api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
