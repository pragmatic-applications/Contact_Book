using System.Threading.Tasks;

using Domain;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    public partial class Delete : ItemBase
    {
        protected override async Task OnInitializedAsync()
        {
            await this.GetAsync(id: this.Id);

            this.FormTitle = "Delete Item";
            this.FormMode = FormMode.Delete;
            this.ButtonText = "Delete";
            this.BannerTitleValue = "Admin - Delete";
        }

        protected override async Task DeleteAsync()
        {
            await this.HttpContactEntityService.DeleteEntityAsync(this.ContactEntityDto.Id);
            this.Reload();
        }
    }
}
