using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardHeader<TEntity> : FlexibleContainerChildElement<ICard<TEntity>>
    {
        protected override void Register(ICard<TEntity> parent) => parent.SetHeader(this);

        protected override string ContainerCssClass => "card_header";

        [Parameter]
        public string Css { get; set; }

        public override RenderFragment RenderContent => (builder =>
        {
            var i = 0;
            builder.OpenElement(i++, "div");
            builder.AddAttribute(i++, "class", this.Css);

            builder.AddContent(i++, this.ChildContent);
            builder.CloseElement();
        });
    }
}
