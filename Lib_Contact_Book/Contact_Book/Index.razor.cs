using System.Threading.Tasks;

using Domain;

namespace Lib_Contact_Book.Contact_Book
{
    [PageTitle("ContactBook", true, true)]
    public partial class Index : ItemBase
    {
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            this.BannerTitleValue = "Admin";
        }
    }
}
