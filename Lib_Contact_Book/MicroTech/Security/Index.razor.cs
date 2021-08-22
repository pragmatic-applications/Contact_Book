using Domain;

namespace Lib_Contact_Book.MicroTech.Security
{
    [PageTitle("Security")]
    public partial class Index : ClientBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "MicroTech Security";
        }
    }
}
