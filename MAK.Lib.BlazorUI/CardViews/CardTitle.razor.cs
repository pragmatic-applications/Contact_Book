using Domain;

using Interfaces;

namespace MAK.Lib.BlazorUI.CardViews
{
    public partial class CardTitle : FlexibleContainerChildElement<ICardBody>
    {
        protected override void Register(ICardBody parent) => parent.SetTitle(this);

        protected override string ContainerCssClass => "card_title";

        public override ElementType ElementType { get; set; } = ElementType.H5;
    }
}
