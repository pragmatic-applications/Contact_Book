using Domain;

namespace Lib_Contact_Book.Contact_Book
{
    [PageTitle("ContactBook", true, true)]
    public partial class Index : ItemBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "ContactBook";
        }
    }
}
