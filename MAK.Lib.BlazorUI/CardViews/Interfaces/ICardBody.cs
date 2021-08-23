using MAK.Lib.BlazorUI.CardViews;

namespace Interfaces
{
    public interface ICardBody
    {
        void SetTitle(CardTitle title);
        void AddText(CardText text);
        void AddLink(CardLink link);
    }
}
