using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Constants;

using HttpServices;

using Interfaces;

using Lib_Blazor_UI;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace Domain
{
    public class ItemBase : AppComponent<ContactEntity, ContactEntityCategory>, IDisposable
    {
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            this.ItemSelect = new ItemSelect();
            this.AppNameValue = "eItem";

            this.Item = new();

            await this.GetEntityCategoryAsync();
            await this.GetAsync();
        }

        public string PrimaryBtnCssClass { get; set; } = "btn btn_primary btn_sm margin_bottom_10";
        public string DangerBtnCssClass { get; set; } = "btn btn_danger btn_sm margin_bottom_10";


        [Inject] public ITaskService<ContactEntity> ITaskService { get; set; }
        [Inject] public HttpItemService ItemService { get; set; }
        [Inject] public HttpItemCategoryService ItemCategoryService { get; set; }

        [Parameter] public ContactEntity ItemParameter { get; set; }
        [Parameter] public List<ContactEntity> ItemsParameter { get; set; }
        [Inject] public ContactEntity Item { get; set; }
        [Inject] public List<ContactEntity> Items { get; set; }

        protected bool IsCrudValue { get; set; } = true;
        protected bool IsPageAdminValue { get; set; } = true;

        [Inject] public List<ContactEntityCategory> Categories { get; set; }

        public PagingResponse<ContactEntity> PagingResponse { get; set; }

        public string IsDone => this.Item.IsChecked ? "Yes" : "No";
        public string EntryId => this.Item.Id < 10 ? $"0{this.Item.Id}" : $"{this.Item.Id}";

        protected void AssignImageUrl(string imgUrl) => this.Item.Image = imgUrl;

        protected override void ClearFields()
        {
            this.Item.Id = 0;
            this.Item.ContactName = string.Empty;
            this.Item.FirstName = string.Empty;
            this.Item.LastName = string.Empty;
            this.Item.Email = string.Empty;
            this.Item.Phone = string.Empty;
            this.Item.Address = string.Empty;
            this.Item.Image = string.Empty;
            this.Item.IsChecked = false;
        }

        protected override void Reload() => this.GoToPage(PageRoute.Admin);

        protected override void LoadDataSuccess(PagingResponse<ContactEntity> data)
        {
            this.Items = data.Items;
            this.PagerData = data.PagerData;
            this.IsLoading = false;
            this.IsError = false;
        }
        protected override void LoadEntityCategoryDataSuccess(List<ContactEntityCategory> data)
        {
            this.Categories = data;
            this.IsLoading = false;
            this.IsError = false;
        }

        protected override void LoadDataFail(Exception exception)
        {
            this.Items = null;
            this.IsError = true;
        }
        protected override void LoadDataCategoryFail(Exception exception)
        {
            this.Categories = null;
            this.IsError = true;
        }

        protected override async Task TryLoadAsync(Action<PagingResponse<ContactEntity>> success, Action<Exception> fail)
        {
            try
            {
                this.PagingResponse = await this.ItemService.GetEntitiesAsync(this.PagingEntity);
                success(this.PagingResponse);
            }
            catch(Exception ex)
            {

                fail(ex);
            }
            finally
            {
                this.IsLoading = false;
            }
        }
        protected override async Task TryLoadAsync(Action<List<ContactEntityCategory>> success, Action<Exception> fail)
        {
            List<ContactEntityCategory> data;

            try
            {
                data = await this.ItemCategoryService.GetEntitiesAsync();
                success(data);
            }
            catch(Exception ex)
            {

                fail(ex);
            }
            finally
            {
                this.IsLoading = false;
            }
        }

        protected override async Task GetAsync() => await this.TryLoadAsync(this.LoadDataSuccess, this.LoadDataFail);
        protected override async Task GetEntityCategoryAsync() => await this.TryLoadAsync(this.LoadEntityCategoryDataSuccess, this.LoadDataCategoryFail);
        protected override async Task GetAsync(int id) => this.Item = await this.ItemService.GetEntityByIdAsync(id: id);

        protected override async Task UpdateAsync()
        {
            await this.ItemService.EditEntityAsync(this.Item.Id, this.Item);
            this.Reload();
        }

        protected override async Task DeleteAsync()
        {
            await this.ItemService.DeleteEntityAsync(this.Item.Id);
            this.Reload();
        }

        //// S SRC

        //public bool NameChange { get; set; }
        //protected void OnNameChange() => this.NameChange = string.IsNullOrWhiteSpace(this.Item.Name);

        //public bool DetailChange { get; set; }
        //protected void OnDetailChange() => this.DetailChange = string.IsNullOrWhiteSpace(this.Item.Detail);

        //protected bool CanAdd => string.IsNullOrWhiteSpace(this.Item.Name) || string.IsNullOrWhiteSpace(this.Item.Detail) || this.NameChange || this.DetailChange || this.IsDisabled;

        //protected void AddItem()
        //{
        //    this.ITaskService.AddItem(this.Item);
        //    this.Item = new();
        //}
        //protected bool CanSave => this.ITaskService.CanSave;

        //// Todo: Update to AddRange for collection...
        //protected override async Task InsertAsync()
        //{
        //    foreach(var item in this.ITaskService.Items)
        //    {
        //        await this.ItemService.AddEntityAsync(item);
        //    }

        //    this.ITaskService.Clear();
        //    this.Reload();
        //}

        //public string CategoryId { get; set; } = "0";
        //public string Zero { get; set; } = "0";
        //protected bool IsDisabled => this.CategoryId == this.Zero;

        //public int GetCategoryId(string categoryId)
        //{
        //    int.TryParse(categoryId, out var result);

        //    return result;
        //}

        //// E SRC

        // S NNN State
        //NameChange => ContactNameState
        public bool ContactNameState { get; set; }
        protected void HandleContactNameFormField() => this.ContactNameState = string.IsNullOrWhiteSpace(this.Item.ContactName);

        public bool FirstNameState { get; set; }
        protected void HandleFirstNameFormField() => this.FirstNameState = string.IsNullOrWhiteSpace(this.Item.FirstName);

        public bool LastNameState { get; set; }
        protected void HandleLastNameFormField() => this.LastNameState = string.IsNullOrWhiteSpace(this.Item.LastName);

        public bool EmailState { get; set; }
        protected void HandleEmailFormField() => this.EmailState = string.IsNullOrWhiteSpace(this.Item.Email);

        public bool PhoneState { get; set; }
        protected void HandlePhoneFormField() => this.PhoneState = string.IsNullOrWhiteSpace(this.Item.Phone);

        //// Orig
        //public bool AddressState { get; set; }
        //protected void HandleAddressFormField() => this.AddressState = string.IsNullOrWhiteSpace(this.Item.Address);

        // Orig
        public bool AddressState { get; set; }
        protected void HandleAddressFormField()
        {
            this.AddressState = string.IsNullOrWhiteSpace(this.Item.Address) || this.Item.Address.Length < 2;
        }

        protected bool CanAdd =>
        string.IsNullOrWhiteSpace(this.Item.ContactName) ||
        string.IsNullOrWhiteSpace(this.Item.FirstName) ||
        string.IsNullOrWhiteSpace(this.Item.LastName) ||
        string.IsNullOrWhiteSpace(this.Item.Email) ||
        string.IsNullOrWhiteSpace(this.Item.Phone) ||
        string.IsNullOrWhiteSpace(this.Item.Address) ||

        this.ContactNameState ||
        this.FirstNameState ||
        this.LastNameState ||
        this.EmailState ||
        this.PhoneState ||
        this.AddressState ||

        this.IsDisabled;

        protected void AddItem()
        {
            this.ITaskService.AddItem(this.Item);
            this.Item = new();
        }

        protected bool CanSave => this.ITaskService.CanSave;

        protected override async Task InsertAsync()
        {
            foreach(var item in this.ITaskService.Items)
            {
                await this.ItemService.AddEntityAsync(item);
            }

            this.ITaskService.Clear();
            this.Reload();
        }

        public string CategoryId { get; set; } = "0";
        public string Zero { get; set; } = "0";
        protected bool IsDisabled => this.CategoryId == this.Zero;

        public int GetCategoryId(string categoryId)
        {
            int.TryParse(categoryId, out var result);

            return result;
        }
        // E NNN

        //// S Form State
        //public int CurrentCheckboxId { get; set; }
        //public int GetCheckboxId()
        //{
        //    var id = 1;

        //    return ++id;
        //}

        //public bool ContactNameInvalid { get; set; }
        //public bool FirstNameInvalid { get; set; }
        //public bool LastNameInvalid { get; set; }
        //public bool EmailInvalid { get; set; }
        //public bool PhoneInvalid { get; set; }
        //protected bool AddressInvalid { get; set; }

        //protected void HandleContactNameFormField() => this.ContactNameInvalid = this.Item.ContactName.Length < 2;
        //protected void HandleFirstNameFormField() => this.FirstNameInvalid = this.Item.FirstName.Length < 2;
        //protected void HandleLastNameFormField() => this.LastNameInvalid = this.Item.LastName.Length < 2;
        //protected void HandleEmailFormField() => this.EmailInvalid = this.Item.Email.Length < 2;
        //protected void HandlePhoneFormField() => this.PhoneInvalid = this.Item.Phone.Length < 2;
        //protected void HandleAddressFormField() => this.AddressInvalid = this.Item.Address.Length < 2;

        //protected int CurrentCategoryId;

        //public bool AddDisabled => this.ContactNameInvalid || this.AddressInvalid;

        //protected void AddItem()
        //{
        //    this.ITaskService.AddItem(this.Item);
        //    this.Item = new();
        //}
        //protected bool CanSave => this.ITaskService.CanSave;

        //protected override async Task InsertAsync()
        //{
        //    foreach(var item in this.ITaskService.Items)
        //    {
        //        await this.ItemService.AddEntityAsync(item);
        //    }

        //    this.ITaskService.Clear();
        //    this.Reload();
        //}

        //public string CategoryId { get; set; } = "0";
        //public string Zero { get; set; } = "0";
        //protected bool IsDisabled => this.CategoryId == this.Zero;

        //public int GetCategoryId(string categoryId)
        //{
        //    int.TryParse(categoryId, out var result);

        //    return result;
        //}
        //// E Form State

        public void Dispose()
        {
            this.ItemSelect = null;
            this.ItemService = null;
            this.Item = null;
            this.Items = null;
            this.ItemCategoryService = null;
            this.Categories = null;
            this.PagingResponse = null;
        }
    }
}
