using System;
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

            this.CurrentCategoryId = this.ContactEntityDto.ContactEntityCategoryId;
            this.CategoryId = this.ContactEntityDto.ContactEntityCategoryId.ToString();
        }

        public CategoryFeedback GetCategoryFeedback()
        {
            CategoryFeedback data = new();

            if(this.CurrentCategoryId > 0 && this.CurrentCategoryId < 8)
            {
                switch(this.CurrentCategoryId)
                {
                    case ((int)ContactCategoryType.Unspecified):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Unspecified);
                    return data;

                    case ((int)ContactCategoryType.Owner):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Owner);
                    return data;

                    case ((int)ContactCategoryType.Family):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Family);
                    return data;

                    case ((int)ContactCategoryType.Friend):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Friend);
                    return data;

                    case ((int)ContactCategoryType.Home):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Home);
                    return data;

                    case ((int)ContactCategoryType.Work):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Work);
                    return data;

                    case ((int)ContactCategoryType.Business):
                    data.Id = this.CurrentCategoryId;
                    data.Category = Enum.GetName(ContactCategoryType.Business);
                    return data;
                }
            }

            return data;
        }
    }

    public class CategoryFeedback
    {
        public int Id { get; set; }
        public string Category { get; set; }
    }
}
