using Domain;

namespace Lib_Contact_Book
{
    public partial class Index : ItemBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "Home";

            this.IsCrudValue = false;
            this.IsPageAdminValue = false;
            this.IsCrudCascadingParameter = false;
            this.IsPageAdminCascadingParameter = false;
        }
    }
}
