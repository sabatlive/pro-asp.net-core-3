#pragma checksum "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5b61ffedf48740b96a0e6011cf9d98ed546b66"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/departments")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/depts")]
    public partial class DepartmentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Advanced.Blazor.DepartmentList.TypeInference.CreateCascadingValue_0(__builder, 0, 1, "BgTheme", 2, 
#nullable restore
#line 4 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                      Theme

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 4 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                                      false

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Advanced.Blazor.TableTemplate<Department>>(6);
                __builder2.AddAttribute(7, "RowData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Department>>(
#nullable restore
#line 5 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                                 Departments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Highlight", new System.Func<Department, System.String>(
#nullable restore
#line 6 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                     d => d.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "SortDirection", new System.Func<Department, System.String>(
#nullable restore
#line 7 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                         d => d.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.AddMarkupContent(12, "<tr><th>ID</th><th>Name</th><th>People</th><th>Locations</th></tr>\r\n        ");
                }
                ));
                __builder2.AddAttribute(13, "RowTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Department>)((d) => (__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.OpenElement(15, "td");
                    __builder3.AddContent(16, 
#nullable restore
#line 12 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                 d.Departmentid

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n            ");
                    __builder3.OpenElement(18, "td");
                    __builder3.AddContent(19, 
#nullable restore
#line 13 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                 d.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenElement(21, "td");
                    __builder3.AddContent(22, 
#nullable restore
#line 14 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                  String.Join(", ", d.People.Select(p => p.Surname))

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenElement(24, "td");
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.AddContent(26, 
#nullable restore
#line 16 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                  String.Join(", ", 
                    d.People.Select(p => p.Location.City).Distinct())

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(27, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n");
            }
            );
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenComponent<Advanced.Blazor.SelectFilter>(31);
            __builder.AddAttribute(32, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                       "Theme"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "Values", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 23 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                         Themes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "SelectedValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                                                      Theme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "SelectedValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Theme = __value, Theme))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
                                          HandleClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "People");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\HP\Documents\GitHub\pro-asp.net-core-3\36 - Blazor Forms\End of Chapter\Advanced\Blazor\DepartmentList.razor"
       

    [Inject]
    public DataContext Context { get; set; }

    public IEnumerable<Department> Departments => Context.Departments
            .Include(d => d.People).ThenInclude(p => p.Location);

    public string Theme { get; set; } = "info";
    public string[] Themes = new string[] { "primary", "info", "success" };

    [Inject]
    public NavigationManager NavManager { get; set; }

    public void HandleClick() => NavManager.NavigateTo("/people");

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Advanced.Blazor.DepartmentList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "IsFixed", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
