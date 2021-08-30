using System.Threading.Tasks;

using Domain;

namespace Lib_Contact_Book.Contact_Book.Admin
{
    public partial class Create : ItemBase
    {
        protected override void OnInitialized()
        {
            this.FormTitle = "Add Entry";
            this.FormMode = FormMode.Create;
            this.ButtonText = "Save";
            this.BannerTitleValue = "Admin - Create";
        }

        public bool ContactNameState { get; set; }
        protected void HandleContactNameFormField() => this.ContactNameState = string.IsNullOrWhiteSpace(this.ContactEntityDto.ContactName);


        public bool FirstNameState { get; set; }
        protected void HandleFirstNameFormField() => this.FirstNameState = string.IsNullOrWhiteSpace(this.ContactEntityDto.FirstName);


        public bool LastNameState { get; set; }
        protected void HandleLastNameFormField() => this.LastNameState = string.IsNullOrWhiteSpace(this.ContactEntityDto.LastName);


        public bool EmailState { get; set; }
        protected void HandleEmailFormField() => this.EmailState = string.IsNullOrWhiteSpace(this.ContactEntityDto.Email);


        public bool PhoneState { get; set; }
        protected void HandlePhoneFormField() => this.PhoneState = string.IsNullOrWhiteSpace(this.ContactEntityDto.Phone);


        public bool AddressState { get; set; }
        protected void HandleAddressFormField() => this.AddressState = string.IsNullOrWhiteSpace(this.ContactEntityDto.Address) || this.ContactEntityDto.Address.Length < 2;

        protected bool CanSave => this.TaskService.CanSave;

        protected override async Task InsertAsync()
        {
            foreach(var item in this.TaskService.Items)
            {
                await this.HttpContactEntityService.PostEntityAsync(item);
            }

            this.TaskService.Clear();
            this.Reload();
        }

        protected bool CanAdd =>
        string.IsNullOrWhiteSpace(this.ContactEntityDto.ContactName) ||
        string.IsNullOrWhiteSpace(this.ContactEntityDto.FirstName) ||
        string.IsNullOrWhiteSpace(this.ContactEntityDto.LastName) ||
        string.IsNullOrWhiteSpace(this.ContactEntityDto.Email) ||
        string.IsNullOrWhiteSpace(this.ContactEntityDto.Phone) ||
        string.IsNullOrWhiteSpace(this.ContactEntityDto.Address) ||

        this.ContactNameState ||
        this.FirstNameState ||
        this.LastNameState ||
        this.EmailState ||
        this.PhoneState ||
        this.AddressState ||

        this.IsDisabled;

        protected void AddItem()
        {
            this.TaskService.AddItem(this.ContactEntityDto);
            this.ContactEntityDto = new();
        }        
    }
}
