﻿using System.Collections.Generic;

using Constants;

using DTOs;

using Lib_Blazor_UI;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.Contact_Book.Views
{
    public partial class Table : Component
    {
        [CascadingParameter(Name = nameof(CascadingData.EntitiesParameterValue))]
        public List<ContactEntityDto> EntitiesCascadingParameter { get; set; }
    }
}