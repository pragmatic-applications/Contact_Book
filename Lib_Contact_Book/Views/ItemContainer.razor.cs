using Lib_Blazor_UI;

using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Views
{
    public partial class ItemContainer : UIEntityBase
    {
        [CascadingParameter(Name = nameof(CascadingData.EntityParameterValue))]
        public ContactEntity EntityCascadingParameter { get; set; }

        public string IsDone => this.EntityCascadingParameter.IsChecked ? "Yes" : "No";
        public string EntryId => this.EntityCascadingParameter.Id < 10 ? $"0{this.EntityCascadingParameter.Id}" : $"{this.EntityCascadingParameter.Id}";
    }
}
