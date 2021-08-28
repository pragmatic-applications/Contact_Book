using System.Collections.Generic;

using Constants;

using Domain;

using DTOs;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Contact_Book
{
    public partial class IndexContainer : Component
    {
        [CascadingParameter(Name = nameof(CascadingData.EntitiesParameterValue))]
        public List<ContactEntityDto> EntitiesCascadingParameter { get; set; }

        private string GetIsChecked(ContactEntityDto item) => item.IsChecked ? "Yes" : "No";

        private string GetId(ContactEntityDto item) => item.Id < 10 ? $"0{item.Id}" : $"{item.Id}";

        private string GetLink(ContactEntityDto item) => $"{PageRoute.S_Details}/{item.Id}";
    }
}
