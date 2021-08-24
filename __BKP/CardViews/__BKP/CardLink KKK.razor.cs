//using Constants;

//using Domain;

//using Interfaces;

//using Microsoft.AspNetCore.Components;

//namespace MAK.Lib.BlazorUI.CardViews
//{
//    public partial class CardLink : ChildElement<ICardBody>
//    {
//        protected override void Register(ICardBody parent) => parent.AddLink(this);

//        [Parameter]
//        public RenderFragment ChildContent { get; set; }

//        [Parameter]
//        public string LinkUrl { get; set; }

//        [CascadingParameter(Name = nameof(CascadingData.TargetUrlCascadingValue))]
//        public string TargetUrlCascadingParameter { get; set; }

//        [CascadingParameter(Name = nameof(CascadingData.CardLinkCssCascadingValue))]
//        public string CardLinkCssCascadingParameter { get; set; }

//        public override RenderFragment RenderContent => (builder =>
//        {
//            builder.OpenElement(0, "a");
//            builder.AddAttribute(1, "class", this.CardLinkCssCascadingParameter);

//            builder.AddAttribute(2, "href", this.TargetUrlCascadingParameter);
//            builder.AddContent(3, this.ChildContent);
//            builder.CloseElement();
//        });
//    }
//}
