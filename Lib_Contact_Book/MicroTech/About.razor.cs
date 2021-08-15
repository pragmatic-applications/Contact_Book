using Domain;

namespace Lib_Contact_Book.MicroTech
{
    public partial class About : ClientBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "About";
        }
    }
}
