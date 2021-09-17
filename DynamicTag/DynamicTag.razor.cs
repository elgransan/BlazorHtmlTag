using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DynamicTag
{
    public class DynamicTag : ComponentBase
    {
        [Parameter]
        public string Tag { get; set; } = "div";

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder __builder)
        {
            var ix = 0;
            __builder.OpenElement(ix++, Tag);
            if (ChildContent != null)
            {
                __builder.AddContent(ix++, ChildContent);
            }
            __builder.CloseElement();
        }
    }
}
