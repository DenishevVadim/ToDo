#pragma checksum "/home/vadim/Documents/GitHub/ToDo/Pages/TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd688c8bb656d21cc093b57778a76e3cbc8afb0e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TODO_List.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using TODO_List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/vadim/Documents/GitHub/ToDo/_Imports.razor"
using TODO_List.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/vadim/Documents/GitHub/ToDo/Pages/TodoList.razor"
using TODO_List.Infrastructure.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todolist")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/home/vadim/Documents/GitHub/ToDo/Pages/TodoList.razor"
       

    void Delete(int id)
    {
        service.RemoveAt(id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TodoService service { get; set; }
    }
}
#pragma warning restore 1591
