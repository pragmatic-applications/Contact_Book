using Domain;

namespace Lib_Contact_Book
{
    public partial class About : ItemBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "About";
        }
    }
}
