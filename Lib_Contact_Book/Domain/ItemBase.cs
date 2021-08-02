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

        public int CurrentCheckboxId { get; set; }
        public int GetCheckboxId()
        {
            var id = 1;

            return ++id;
        }

        public bool ContactNameChange { get; set; }
        public bool FirstNameChange { get; set; }
        public bool LastNameChange { get; set; }
        public bool EmailChange { get; set; }
        public bool PhoneChange { get; set; }
        public bool AddressChange { get; set; }

        protected void OnContactNameChange() => this.ContactNameChange = string.IsNullOrWhiteSpace(this.Item.ContactName);
        protected void OnFirstNameChange() => this.FirstNameChange = string.IsNullOrWhiteSpace(this.Item.FirstName);
        protected void OnLastNameChange() => this.LastNameChange = string.IsNullOrWhiteSpace(this.Item.LastName);
        protected void OnEmailChange() => this.EmailChange = string.IsNullOrWhiteSpace(this.Item.Email);
        protected void OnPhoneChange() => this.PhoneChange = string.IsNullOrWhiteSpace(this.Item.Phone);
        protected void OnAddressChange() => this.AddressChange = string.IsNullOrWhiteSpace(this.Item.Address);

        protected bool CanAdd =>
        string.IsNullOrWhiteSpace(this.Item.ContactName) ||
        string.IsNullOrWhiteSpace(this.Item.FirstName) ||
        string.IsNullOrWhiteSpace(this.Item.LastName) ||
        string.IsNullOrWhiteSpace(this.Item.Email) ||
        string.IsNullOrWhiteSpace(this.Item.Phone) ||
        string.IsNullOrWhiteSpace(this.Item.Address) ||
        this.ContactNameChange ||
        this.FirstNameChange ||
        this.LastNameChange ||
        this.EmailChange ||
        this.PhoneChange ||
        this.AddressChange ||
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

//====================
/*public class ContactEntity
{
    public int Id { get; set; }
    public string ContactName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Image { get; set; } = "Default.png";
    public bool IsChecked { get; set; } = false;
    public int ContactEntityCategoryId { get; set; } = (int)ContactCategoryType.Unspecified;
}//*/

//Contact_Book_Server_Api
