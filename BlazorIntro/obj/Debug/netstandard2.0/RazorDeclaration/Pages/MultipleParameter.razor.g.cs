#pragma checksum "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04040ee87ef6c6b4bdfdc322262d5317affa535e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/multipleparameter")]
    public class MultipleParameter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 7 "C:\Users\Lenovo\source\repos\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
       
    [Parameter]
    public string MaxLength { get; set; } = "10";
    [Parameter]
    public string Placeholder { get; set; } = "First Name";
    [Parameter]
    public string Required { get; set; } = "required";
    [Parameter]
    public string Size { get; set; } = "50";

    public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>
    {
        {"maxlength","10" },
        {"placeholder","FirstName" },
        {"required","required" },
        {"size","50" }
    };


#line default
#line hidden
    }
}
#pragma warning restore 1591
