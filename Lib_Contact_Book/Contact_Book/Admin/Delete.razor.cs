using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Lib_Blazor_UI;
using Domain;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    public partial class Delete : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await this.GetAsync(id: this.Id);

            this.FormTitle = "Delete Item";
            this.FormMode = FormMode.Delete;
            this.ButtonText = "Delete";
            this.BannerTitleValue = "Admin - Delete";
        }
    }
}
