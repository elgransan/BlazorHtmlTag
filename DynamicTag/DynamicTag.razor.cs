using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;

namespace DynamicTag
{
    public class DynamicTag : ComponentBase
    {
        [Parameter]
        public string Tag { get; set; } = "div";

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> TagAttributes { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
            var ix = 0;
            __builder.OpenElement(ix++, Tag);
            __builder.AddMultipleAttributes(ix++, TagAttributes);
            if (ChildContent != null)
            {
                __builder.AddContent(ix++, ChildContent);
            }
            __builder.CloseElement();
        }
    }
}
