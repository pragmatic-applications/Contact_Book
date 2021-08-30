using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardFooter<TEntity> : ContainerChildElement<ICard<TEntity>>
    {
        protected override void Register(ICard<TEntity> parent) => parent.SetFooter(this);

        protected override string ContainerCssClass => "card_footer";


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
