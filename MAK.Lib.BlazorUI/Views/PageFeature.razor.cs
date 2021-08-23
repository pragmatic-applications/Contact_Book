using Domain;

using PageFeatures;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class PageFeature : CoreComponent
    {
        public PagerData PagerDataValue { get; set; }

        protected override void OnParametersSet() => this.PagerDataValue = this.PagerDataParameter;
    }
}
