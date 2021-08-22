using Domain;

namespace Lib_Contact_Book.MicroTech
{
    [PageTitle("About")]
    public partial class About : ClientBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "MicroTech About";
        }
    }
}
