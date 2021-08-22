using System.Threading.Tasks;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    public partial class Update : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await this.GetAsync(id: this.Id);

            CoreComponent.EntityId = this.Id;

            this.FormTitle = "Update Item";
            this.FormMode = FormMode.Update;
            this.ButtonText = "Save";
            this.BannerTitleValue = "Admin - Update";
        }
    }
}
