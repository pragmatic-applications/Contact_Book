using System.Threading.Tasks;

using Constants;

using Domain;

using HttpServices;

using Microsoft.AspNetCore.Components;

namespace Lib_Contact_Book.MicroTech.Contacts
{
    public class ContactBase : ClientBase
    {
        [Inject] public HttpContactService HttpContactService { get; set; }

        [Inject] public AppContact AppContact { get; set; }

        protected async Task SendContactAsync()
        {
            await this.HttpContactService.DoActionAsync(this.AppContact);

            ContactFeedbackViewModel.IsVisible = true;
            ContactFeedbackViewModel.FullName = this.AppContact.Title + " " + this.AppContact.FirstName + " " + this.AppContact.LastName;

            this.GoToPage(PageRoute.MicroTechContactFeedback);
        }
    }
}
