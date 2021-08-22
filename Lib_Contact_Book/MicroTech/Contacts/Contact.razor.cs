using Domain;

namespace Lib_Contact_Book.MicroTech.Contacts
{
    [PageTitle("Contact")]
    public partial class Contact : ContactBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.BannerTitleValue = "MicroTech Contact";
            this.ButtonText = "Send";
        }
    }
}
