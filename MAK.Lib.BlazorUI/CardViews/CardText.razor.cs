using Domain;

using Interfaces;

namespace MAK.Lib.BlazorUI.CardViews
{
    public partial class CardText : ContainerChildElement<ICardBody>
    {
        protected override void Register(ICardBody parent) => parent.AddText(this);

        protected override string ContainerCssClass => "card_text";
        protected override ElementType ContainerChildElementType => ElementType.P;
    }
}
