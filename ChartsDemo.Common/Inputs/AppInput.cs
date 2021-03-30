using System;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Common.Web
{
    public class AppInput<T> : ComponentBase
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public T Value { get; set; }

        [Parameter]
        public EventCallback<T> ValueChanged { get; set; }

        [Parameter]
        public Expression<Func<T>> ValidationExpression { get; set; }

        [Parameter]
        public EventCallback<FocusEventArgs> OnFocusOut { get; set; }

        [Parameter]
        public string Width { get; set; } = "100%";

        [Parameter]
        public bool Disabled { get; set; }
    }
}
