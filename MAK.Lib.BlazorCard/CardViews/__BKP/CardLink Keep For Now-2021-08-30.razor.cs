//using Domain;

//using Interfaces;

//using Microsoft.AspNetCore.Components;

//namespace MAK.Lib.BlazorCard.CardViews
//{
//    public partial class CardLink<TEntity> : ChildElement<ICardBody<TEntity>>
//    {
//        protected override void Register(ICardBody<TEntity> parent) => parent.AddLink(this);

//        [Parameter]
//        public RenderFragment ChildContent { get; set; }

//        [Parameter]
//        public string LinkUrl { get; set; }

//        [Parameter]
//        public string Css { get; set; }

//        private const string TargetUrlCascadingValue = "TargetUrlCascadingValue";
//        private const string CardLinkCssCascadingValue = "CardLinkCssCascadingValue";

//        [CascadingParameter(Name = nameof(TargetUrlCascadingValue))]
//        public string TargetUrlCascadingParameter { get; set; }

//        [CascadingParameter(Name = nameof(CardLinkCssCascadingValue))]
//        public string CardLinkCssCascadingParameter { get; set; }

//        public override RenderFragment RenderContent => (builder =>
//        {
//            builder.OpenElement(0, "a");

//            if(!string.IsNullOrWhiteSpace(this.Css))
//            {
//                builder.AddAttribute(1, "class", this.Css);
//            }
//            else
//            {
//                builder.AddAttribute(1, "class", this.CardLinkCssCascadingParameter);
//            }

//            if(!string.IsNullOrWhiteSpace(this.LinkUrl))
//            {
//                builder.AddAttribute(2, "href", this.LinkUrl);
//            }
//            else
//            {
//                builder.AddAttribute(2, "href", this.TargetUrlCascadingParameter);
//            }

//            builder.AddContent(3, this.ChildContent);
//            builder.CloseElement();
//        });
//    }
//}
