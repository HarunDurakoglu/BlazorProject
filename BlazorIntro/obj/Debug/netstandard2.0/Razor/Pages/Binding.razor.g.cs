#pragma checksum "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Binding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a24c6e90140fa729035b8c7cd78b3f3e6461e353"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/binding")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/baglama")]
    public class Binding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Binding</h3>\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 4 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Binding.razor"
                    FirstName

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FirstName = __value, FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "h3");
            __builder.AddContent(6, 
#line 6 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Binding.razor"
     FirstName

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 8 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\Binding.razor"
       
    public string FirstName { get; set; } = "Engin";

#line default
#line hidden
    }
}
#pragma warning restore 1591
