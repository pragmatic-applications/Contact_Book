namespace Lib_Contact_Book.MicroTech.Contacts
{
    public partial class Guest : ContactBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "Guest";
        }
    }
}
