using Domain;

using Interfaces;

namespace MAK.Lib.BlazorUI.CardViews
{
    public partial class CardFooter<TEntity> : ContainerChildElement<ICard<TEntity>>
    {
        protected override void Register(ICard<TEntity> parent) => parent.SetFooter(this);

        protected override string ContainerCssClass => "card_footer";
    }
}
