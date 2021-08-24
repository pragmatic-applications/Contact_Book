using Microsoft.AspNetCore.Components;

namespace Domain
{
    public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
    {
        [Parameter]
        public virtual ElementType ElementType { get; set; } = ElementType.Div;

        protected override ElementType ContainerChildElementType => this.ElementType;
    }
}
