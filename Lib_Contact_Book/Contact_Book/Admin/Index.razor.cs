using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    [PageTitle("Admin")]
    public partial class Index : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "Admin";

            this.IsCrudValue = true;
            this.IsPageAdminValue = true;
            this.IsPageAdminCascadingParameter = true;
            this.IsCrudCascadingParameter = true;
        }
    }
}
