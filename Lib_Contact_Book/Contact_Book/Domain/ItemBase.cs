using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Constants;

using DTOs;

using HttpServices;

using Interfaces;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace Domain
{
    public class ItemBase : AppComponent<ContactEntityDto, ContactEntityCategory>, IDisposable
    {
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            this.AppNameValue = "eItem";

            this.ContactEntityDto = new();

            await this.GetEntityCategoryAsync();
            await this.GetAsync();
        }

        // Todo: create a CSS utility calss...
        public string PrimaryBtnCssClass { get; set; } = "btn btn_primary btn_sm margin_bottom_10";

        public string DangerBtnCssClass { get; set; } = "btn btn_danger btn_sm margin_bottom_10";

        [Inject] public ITaskService<ContactEntityDto> TaskService { get; set; }

        [Inject] public HttpItemCategoryService ItemCategoryService { get; set; }

        [Parameter] public ContactEntity ItemParameter { get; set; }

        [Parameter] public List<ContactEntity> ItemsParameter { get; set; }

        [Inject] public ContactEntityDto ContactEntityDto { get; set; }

        [Inject] public List<ContactEntityDto> ContactEntityDtos { get; set; }

        [Inject] public HttpContactEntityService HttpContactEntityService { get; set; }

        [Inject] public List<ContactEntityCategory> Categories { get; set; }

        public PagingResponse<ContactEntityDto> PagingResponse { get; set; }

        public string IsDone => this.ContactEntityDto.IsChecked ? "Yes" : "No";

        public string EntryId => this.ContactEntityDto.Id < 10 ? $"0{this.ContactEntityDto.Id}" : $"{this.ContactEntityDto.Id}";


        protected void AssignImageUrl(string imgUrl) => this.ContactEntityDto.Image = imgUrl;


        protected override void ClearFields()
        {
            this.ContactEntityDto.Id = 0;
            this.ContactEntityDto.ContactName = string.Empty;
            this.ContactEntityDto.FirstName = string.Empty;
            this.ContactEntityDto.LastName = string.Empty;
            this.ContactEntityDto.Email = string.Empty;
            this.ContactEntityDto.Phone = string.Empty;
            this.ContactEntityDto.Address = string.Empty;
            this.ContactEntityDto.Image = string.Empty;
            this.ContactEntityDto.IsChecked = false;
        }


        protected override void Reload() => this.GoToPage(PageRoute.ContactBookAdmin);


        protected override void LoadDataSuccess(PagingResponse<ContactEntityDto> data)
        {
            this.ContactEntityDtos = data.Items;
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
            this.ContactEntityDtos = null;
            this.IsError = true;
        }


        protected override void LoadDataCategoryFail(Exception exception)
        {
            this.Categories = null;
            this.IsError = true;
        }


        protected override async Task TryLoadAsync(Action<PagingResponse<ContactEntityDto>> success, Action<Exception> fail)
        {
            try
            {
                this.PagingResponse = await this.HttpContactEntityService.GetEntitiesAsync(this.PagingEntity);
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


        protected override async Task GetAsync(int id) => this.ContactEntityDto = await this.HttpContactEntityService.GetEntityByIdAsync(id: id);


        protected override async Task InsertAsync()
        {
            foreach(var item in this.TaskService.Items)
            {
                await this.HttpContactEntityService.PostEntityAsync(item);
            }

            this.TaskService.Clear();
            this.Reload();
        }


        protected override async Task UpdateAsync()
        {
            await this.HttpContactEntityService.PutEntityAsync(this.ContactEntityDto.Id, this.ContactEntityDto);
            this.Reload();
        }


        protected override async Task DeleteAsync()
        {
            await this.HttpContactEntityService.DeleteEntityAsync(this.ContactEntityDto.Id);
            this.Reload();
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


        public string CategoryId { get; set; } = "0";

        public string Zero { get; set; } = "0";

        protected bool IsDisabled => this.CategoryId == this.Zero;


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


        protected bool CanSave => this.TaskService.CanSave;


        public int GetCategoryId(string categoryId)
        {
            int.TryParse(categoryId, out var result);

            return result;
        }

        public void Dispose()
        {
            this.HttpContactEntityService = null;
            this.ContactEntityDto = null;
            this.ContactEntityDtos = null;
            this.ItemCategoryService = null;
            this.Categories = null;
            this.PagingResponse = null;
        }
    }
}
