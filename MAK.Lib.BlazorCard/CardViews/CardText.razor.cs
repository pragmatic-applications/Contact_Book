using Domain;

using Interfaces;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardText<TEntity> : ContainerChildElement<ICardBody<TEntity>>
    {
        protected override void Register(ICardBody<TEntity> parent) => parent.AddText(this);

        protected override string ContainerCssClass => "card_text";
        protected override ElementType ContainerChildElementType => ElementType.P;
    }
}
