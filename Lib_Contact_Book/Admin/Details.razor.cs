using System.Threading.Tasks;

using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Admin
{
    //public partial class Details : ItemBase
    //{
    //    [Parameter] public int Id { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        await base.OnInitializedAsync();
    //        await this.GetAsync(id: this.Id);

    //        this.UrlUpdate = $"{PageRoute.S_AdminUpdate_S}{this.Item.Id}";
    //        this.UrlDelete = $"{PageRoute.S_AdminDelete_S}{this.Item.Id}";

    //        this.BannerTitleValue = "Admin - Details";

    //        //CategoryName = Item.ContactEntityCategory.Name;
    //        //var dddd = this.Item.ContactEntityCategoryId;
    //    }

    //    public string CategoryName { get; set; }
    //}
    public partial class Details : ItemBase
    {
        [Parameter] public int Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await this.GetAsync(id: this.Id);

            this.UrlUpdate = $"{PageRoute.S_AdminUpdate_S}{this.ContactEntityDto.Id}";
            this.UrlDelete = $"{PageRoute.S_AdminDelete_S}{this.ContactEntityDto.Id}";

            this.BannerTitleValue = "Admin - Details";
        }
    }
}

//Lib_Blazor_UI
