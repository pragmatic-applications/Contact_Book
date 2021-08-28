using System.Threading.Tasks;

using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Contact_Book
{
    public partial class Details : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await this.GetAsync(id: this.Id);

            this.UrlUpdate = $"{PageRoute.S_AdminUpdate_S}{this.ContactEntityDto.Id}";
            this.UrlDelete = $"{PageRoute.S_AdminDelete_S}{this.ContactEntityDto.Id}";

            this.BannerTitleValue = "Details";
        }
    }
}
