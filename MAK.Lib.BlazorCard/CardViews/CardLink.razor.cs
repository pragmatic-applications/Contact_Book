using Constants;

using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardLink<TEntity> : ChildElement<ICardBody<TEntity>>
    {
        protected override void Register(ICardBody<TEntity> parent) => parent.AddLink(this);

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string LinkUrl { get; set; }

        [Parameter]
        public string LinkCss { get; set; }

        [CascadingParameter(Name = nameof(CascadingData.TargetUrlCascadingValue))]
        public string TargetUrlCascadingParameter { get; set; }

        [CascadingParameter(Name = nameof(CascadingData.CardLinkCssCascadingValue))]
        public string CardLinkCssCascadingParameter { get; set; }

        public override RenderFragment RenderContent => (builder =>
        {
            builder.OpenElement(0, "a");

            if(!string.IsNullOrWhiteSpace(LinkCss))
            {
                builder.AddAttribute(1, "class", this.LinkCss);
            }
            else
            {
                builder.AddAttribute(1, "class", this.CardLinkCssCascadingParameter);
            }

            if(!string.IsNullOrWhiteSpace(LinkUrl))
            {
                builder.AddAttribute(2, "href", this.LinkUrl);
            }
            else
            {
                builder.AddAttribute(2, "href", this.TargetUrlCascadingParameter);
            }

            builder.AddContent(3, this.ChildContent);
            builder.CloseElement();
        });
    }
}
