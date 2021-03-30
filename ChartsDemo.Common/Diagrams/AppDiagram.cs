using System.Collections.Generic;
using ChartsDemo.Common.Shared;
using Microsoft.AspNetCore.Components;

namespace Common.Web
{
    public class AppDiagram : ComponentBase
    {
        [Parameter]
        public List<ChartData> Data { get; set; }

        [Parameter]
        public string Width { get; set; } = "100%";

        [Parameter]
        public string Height { get; set; } = "500px";

        [Parameter]
        public bool ShowLegend { get; set; } = true;
    }
}
