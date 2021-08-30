using System.Threading.Tasks;

using Domain;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    [PageTitle("Admin")]
    public partial class Index : ItemBase
    {
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            this.BannerTitleValue = "Admin";
        }
    }
}
