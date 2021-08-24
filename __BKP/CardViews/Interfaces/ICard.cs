using MAK.Lib.BlazorUI.CardViews;

namespace Interfaces
{
    public interface ICard<TEntity>
    {
        void SetHeader(CardHeader<TEntity> header);
        void SetFooter(CardFooter<TEntity> footer);
        void AddBody(CardBody<TEntity> body);
        void ChildStateChanged();
    }
}


//@typeparam TEntity
// <TEntity>
