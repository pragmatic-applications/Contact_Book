using Domain;

using Interfaces;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardTitle<TEntity> : FlexibleContainerChildElement<ICardBody<TEntity>>
    {
        protected override void Register(ICardBody<TEntity> parent) => parent.SetTitle(this);

        protected override string ContainerCssClass => "card_title";

        public override ElementType ElementType { get; set; } = ElementType.H5;
    }
}
