#pragma checksum "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab5e4e6497fafbda785039709cb410717d6c1600"
// <auto-generated/>
#pragma warning disable 1591
namespace Common.Web
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using ChartsDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using ChartsDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/_Imports.razor"
using Common.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    public partial class PieDiagram : AppDiagram
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", 
#nullable restore
#line 6 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
             $"height: {Height}; width: {Width}"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfAccumulationChart>(2);
            __builder.AddAttribute(3, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
                                 Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Background", "transparent");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartLegendSettings>(6);
                __builder2.AddAttribute(7, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeriesCollection>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.AccumulationChartSeries>(11);
                    __builder3.AddAttribute(12, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
                                                 Data

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "XName", "Id");
                    __builder3.AddAttribute(14, "YName", "Data");
                    __builder3.AddAttribute(15, "PointColorMapping", "Color");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Charts.AccumulationDataLabelSettings>(17);
                        __builder4.AddAttribute(18, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "/Users/kristof/Documents/Projects/ChartsDemo/ChartsDemo/Diagrams/PieDiagram.razor"
                                                        true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Name", "Label");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
