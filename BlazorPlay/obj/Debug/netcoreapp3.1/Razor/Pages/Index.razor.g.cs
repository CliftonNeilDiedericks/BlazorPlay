#pragma checksum "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a079012cac427bf0785d4df289e849f204deca18"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPlay.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Neilo\source\repos\BlazorPlay\BlazorPlay\_Imports.razor"
using BlazorPlay.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<BlazorPlay.Pages.TaskList>(7);
            __builder.AddAttribute(8, "Name", "Neilo");
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        <br>\r\n        <br>\r\n        <hr>\r\n\r\n        ");
            __builder.OpenComponent<BlazorPlay.Pages.TaskList>(10);
            __builder.AddAttribute(11, "Name", "Angel");
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-4");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenComponent<BlazorPlay.Pages.FetchData>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-4");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenComponent<BlazorPlay.Pages.Counter>(23);
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
