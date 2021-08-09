using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Constants;

using DTOs;

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


        //// Orig - YYY
        //[Inject] public ITaskService<ContactEntity> TaskService { get; set; }

        //ContactEntityDto
        [Inject] public ITaskService<ContactEntityDto> TaskService { get; set; }

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

        //protected void AssignImageUrl(string imgUrl) => this.Item.Image = imgUrl;
        protected void AssignImageUrl(string imgUrl) => this.ContactEntityDto.Image = imgUrl;

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

        //protected override async Task GetAsync(int id) => this.Item = await this.ItemService.GetEntityByIdAsync(id: id); // Orig - YYY

        [Inject] public ContactEntityDto ContactEntityDto { get; set; }
        [Inject] public HttpContactEntityService HttpContactEntityGetService { get; set; }
        protected override async Task GetAsync(int id) => this.ContactEntityDto = await this.HttpContactEntityGetService.GetEntityByIdAsync(id: id);

        //// Orig - YYY
        //protected override async Task InsertAsync()
        //{
        //    foreach(var item in this.TaskService.Items)
        //    {
        //        await this.ItemService.AddEntityAsync(item);
        //    }

        //    this.TaskService.Clear();
        //    this.Reload();
        //}

        protected override async Task InsertAsync()
        {
            //// Otig - YYY
            //foreach(var item in this.TaskService.Items)
            //{
            //    await this.ItemService.AddEntityAsync(item);
            //}

            //this.TaskService.Clear();
            //this.Reload();

            foreach(var item in this.TaskService.Items)
            {
                await this.HttpContactEntityGetService.PostEntityAsync(item);
            }

            this.TaskService.Clear();
            this.Reload();
        }



        //// Orig - YYY
        //protected override async Task UpdateAsync()
        //{
        //    await this.ItemService.EditEntityAsync(this.Item.Id, this.Item);
        //    this.Reload();
        //}

        //[Inject] public ContactEntityDtoUpdate ContactEntityDtoUpdate { get; set; }
        //[Inject] public HttpContactEntityPutService HttpContactEntityPutService { get; set; }

        ////NNN...
        //protected override async Task UpdateAsync()
        //{
        //    await this.HttpContactEntityPutService.PutEntityAsync(this.ContactEntityDto.Id, this.ContactEntityDtoUpdate);
        //    this.Reload();
        //}

        protected override async Task UpdateAsync()
        {
            await this.HttpContactEntityGetService.PutEntityAsync(this.ContactEntityDto.Id, this.ContactEntityDto);
            this.Reload();
        }

        protected override async Task DeleteAsync()
        {
            await this.ItemService.DeleteEntityAsync(this.Item.Id);
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
        protected void HandleAddressFormField()
        {
            this.AddressState = string.IsNullOrWhiteSpace(this.ContactEntityDto.Address) || this.ContactEntityDto.Address.Length < 2;
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

        //ContactEntityDto

        //// Orig - YYY
        //protected void AddItem()
        //{
        //    this.TaskService.AddItem(this.Item);
        //    this.Item = new();
        //}

        protected void AddItem()
        {
            this.TaskService.AddItem(this.ContactEntityDto);
            this.ContactEntityDto = new();
        }

        protected bool CanSave => this.TaskService.CanSave;

        //// Orig - YYY
        //protected override async Task InsertAsync()
        //{
        //    foreach(var item in this.ITaskService.Items)
        //    {
        //        await this.ItemService.AddEntityAsync(item);
        //    }

        //    this.ITaskService.Clear();
        //    this.Reload();
        //}

        /*

        services.AddHttpClient<HttpContactEntityPostService>();
            services.AddHttpClient<HttpContactEntityPutService>();

        //*/

        

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
