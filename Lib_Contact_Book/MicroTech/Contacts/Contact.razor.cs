namespace Lib_Contact_Book.MicroTech.Contacts
{
    public partial class Contact : ContactBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.BannerTitleValue = "Contact";
            this.ButtonText = "Send";
        }
    }
}
