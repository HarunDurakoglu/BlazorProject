#pragma checksum "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d88f564b90d0ff098ff7f1a9fd90a101e03441"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/student")]
    public class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 2 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor"
                                               Save

#line default
#line hidden
            ));
            __builder.AddContent(3, "Kaydet Ana Component");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddMarkupContent(5, "<h3>Student List</h3>\r\n");
            __builder.OpenElement(6, "h5");
            __builder.AddContent(7, 
#line 4 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor"
     StudentList

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<BlazorIntro.Pages.StudentDetail>(9);
            __builder.AddAttribute(10, "StudentName", "Engin");
            __builder.AddAttribute(11, "Tikla", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor"
                                           Save

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "h5");
            __builder.AddContent(14, 
#line 8 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor"
     saveMessage

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 10 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Student.razor"
       
    public string StudentList { get; set; }
    private string saveMessage;
    protected override async Task OnInitializedAsync()
    {
        StudentList = "Engin Derin Salih";
    }

    private void Save(MouseEventArgs e)
    {
        saveMessage = "Kaydedildi";
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
