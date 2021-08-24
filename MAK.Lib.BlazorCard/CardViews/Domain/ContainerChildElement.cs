using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Domain
{
    public abstract class ContainerChildElement<TParent> : ChildElement<TParent>
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected virtual ElementType ContainerChildElementType => ElementType.Div;

        protected virtual void CreateRenderContent(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, this.ContainerChildElementType.ToString().ToLower());
            builder.AddAttribute(1, "class", this.ContainerCssClass);
            builder.AddContent(2, this.ChildContent);
            builder.CloseElement();
        }

        protected abstract string ContainerCssClass { get; }

        public override RenderFragment RenderContent => this.CreateRenderContent;
    }
}
