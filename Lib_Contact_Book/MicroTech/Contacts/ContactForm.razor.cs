using Domain;

using Lib_Blazor_UI;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.MicroTech.Contacts
{
    public partial class ContactForm : FormCore
    {
        [Parameter] public AppContact EntityParameter { get; set; }
    }
}
