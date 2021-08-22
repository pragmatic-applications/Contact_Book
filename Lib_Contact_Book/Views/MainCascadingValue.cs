using Interfaces;

namespace Lib_Contact_Book.Views
{
    public class MainCascadingValue
    {
        public MainCascadingValue(ISelect itemSelect, string bannerBackgroundImageCssClass, string positionCssClass, string cardBodyCss, int spread)
        {
            this.ItemSelect = itemSelect;
            this.BannerBackgroundImageCssClass = bannerBackgroundImageCssClass;
            this.PositionCssClass = positionCssClass;
            this.CardBodyCss = cardBodyCss;
            this.Spread = spread;
        }

        public ISelect ItemSelect { get; set; }
        public string BannerBackgroundImageCssClass { get; set; }
        public string PositionCssClass { get; set; }
        public string CardBodyCss { get; set; }
        public int Spread { get; set; }
    }
}
