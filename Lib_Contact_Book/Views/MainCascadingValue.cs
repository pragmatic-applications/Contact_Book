using Interfaces;

namespace Lib_Contact_Book.Views
{
    public class MainCascadingValue
    {
        public MainCascadingValue(ISelect itemSelect, string bannerBackgroundImageCssClass, string positionCssClass, int spread)
        {
            ItemSelect = itemSelect;
            BannerBackgroundImageCssClass = bannerBackgroundImageCssClass;
            PositionCssClass = positionCssClass;
            Spread = spread;
        }

        public ISelect ItemSelect { get; set; }
        public string BannerBackgroundImageCssClass { get; set; }
        public string PositionCssClass { get; set; }
        public int Spread { get; set; }
    }
}
