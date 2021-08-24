using MAK.Lib.BlazorUI.CardViews;

namespace Interfaces
{
    public interface ICardBody<TEntity>
    {
        void SetTitle(CardTitle<TEntity> title);
        void AddText(CardText<TEntity> text);
        void AddLink(CardLink<TEntity> link);
    }
}
