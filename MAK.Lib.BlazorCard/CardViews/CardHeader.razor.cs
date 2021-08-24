using Domain;

using Interfaces;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardHeader<TEntity> : FlexibleContainerChildElement<ICard<TEntity>>
    {
        protected override void Register(ICard<TEntity> parent) => parent.SetHeader(this);

        protected override string ContainerCssClass => "card_header";
    }
}
