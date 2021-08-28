using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Banner : CoreComponent
    {
        [CascadingParameter(Name = nameof(CascadingData.BannerBackgroundImageCssClassParameterValue))]
        public string BannerBackgroundImageCssClassCascadingParameter { get; set; }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            if(string.IsNullOrWhiteSpace(this.BannerTitleParameter))
            {
                this.HeaderTitle = "MVC & Razor UI";
            }
            else if(this.BannerTitleParameter == "Page Not Found")
            {
                this.HeaderTitle = this.BannerTitleParameter;
                this.AppName = this.BannerTitleParameter;
            }
            else
            {
                this.HeaderTitle = this.AppNameParameter + " | " + this.BannerTitleParameter;
                this.AppName = this.AppNameParameter;
            }
        }
    }
}
