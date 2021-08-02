using System.Collections.Generic;

using Lib_Blazor_UI;

using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Views
{
    public partial class ItemCard : HomeBase
    {
        [CascadingParameter(Name = nameof(CascadingData.EntitiesParameterValue))]
        public List<ContactEntity> EntitiesCascadingParameter { get; set; }
    }
}
