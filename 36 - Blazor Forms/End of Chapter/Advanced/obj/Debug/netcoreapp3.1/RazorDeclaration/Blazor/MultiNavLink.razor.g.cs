#pragma checksum "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\MultiNavLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbec02f6b54211ae15eed2b68918017ae17b6478"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Advanced.Blazor
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
    public partial class MultiNavLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\MultiNavLink.razor"
       

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public IEnumerable<string> Href { get; set; }

    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string ActiveClass { get; set; }

    [Parameter]
    public string DisabledClasses { get; set; }

    [Parameter]
    public NavLinkMatch? Match { get; set; }

    public NavLinkMatch ComputedMatch { get =>
            Match ?? (Href.Count() == 1 ? NavLinkMatch.Prefix : NavLinkMatch.All); }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public string ComputedClass { get; set; }


    public void HandleClick() {
        NavManager.NavigateTo(Href.First());
    }

    private void CheckMatch(string currentUrl) {
        string path = NavManager.ToBaseRelativePath(currentUrl);
        path = path.EndsWith("/") ? path.Substring(0, path.Length - 1) : path;
        bool match = Href.Any(href => ComputedMatch == NavLinkMatch.All
                ? path == href : path.StartsWith(href));
        if (!Enabled) {
            ComputedClass = DisabledClasses;
        } else {
            ComputedClass = match ? $"{Class} {ActiveClass}" : Class;
        }
    }

    protected override void OnParametersSet() {
        ComputedClass = Class;
        NavManager.LocationChanged += (sender, arg) => CheckMatch(arg.Location);
        Href = Href.Select(h => h.StartsWith("/") ? h.Substring(1) : h);
        CheckMatch(NavManager.Uri);
    }

    private bool Enabled { get; set; } = true;

    public void SetEnabled(bool enabled) {
        InvokeAsync(() => {
            Enabled = enabled;
            CheckMatch(NavManager.Uri);
            StateHasChanged();
        });
    }

    [JSInvokable]
    public static void ToggleEnabled() => ToggleEvent.Invoke(null, new EventArgs());

    private static event EventHandler ToggleEvent;

    protected override void OnInitialized() {
        ToggleEvent += (sender, args) => SetEnabled(!Enabled);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
