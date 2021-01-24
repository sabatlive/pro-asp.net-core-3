#pragma checksum "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\Forms\ValidButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da0609c6d4f98130fc37514ac2dc873b7d2af19"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Advanced.Blazor.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\_Imports.razor"
using Advanced.Models;

#line default
#line hidden
#nullable disable
    public partial class ValidButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\Forms\ValidButton.razor"
       

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string BtnTheme { get; set; }

    [Parameter]
    public string DisabledClass { get; set;} = "btn-outline-dark disabled";

    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> Attributes { get; set; }

    [CascadingParameter]
    public EditContext CurrentEditContext { get; set; }

    public bool Disabled { get; set; }

    public string ButtonClass => 
        Disabled ? $"btn btn-{BtnTheme} {DisabledClass}" : $"btn btn-{BtnTheme}";

    protected override void OnInitialized() {
        SetButtonState();
        CurrentEditContext.OnValidationStateChanged +=
            (sender, args) => SetButtonState();
        CurrentEditContext.Validate();
    }

    public void SetButtonState() {
        Disabled = CurrentEditContext.GetValidationMessages().Any();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
