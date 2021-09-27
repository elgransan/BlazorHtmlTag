using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDynamicTag
{
    public class HtmlTag : ComponentBase
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
