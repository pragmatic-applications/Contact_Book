using Microsoft.AspNetCore.Components;

using PageFeatures;

using System;
using System.Threading.Tasks;

namespace Domain
{
    public class CoreComponent : Component
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.CurrentTitle = string.IsNullOrWhiteSpace(this.TitleParameter) ? "Blazor & MVC" : this.TitleParameter;
        }


        protected virtual void ClearFields() { }


        protected virtual void Reload()
        {
            this.ClearFields();
            this.NavigationManager.NavigateTo("/");
        }


        protected void GoToPage(string pageToNavigateTo)
        {
            this.ClearFields();
            this.StateHasChanged();
            this.NavigationManager.NavigateTo(pageToNavigateTo);
        }

        [Inject] public PagingEntity PagingEntity { get; set; }
        [Inject] public PagerData PagerData { get; set; }

        [Parameter] public EventCallback<string> OnSearchChanged { get; set; }
        protected async Task SearchChanged(string searchTerm)
        {
            this.PagingEntity.PageNumber = 1;
            this.PagingEntity.SearchTerm = searchTerm;
            await this.GetAsync();
        }

        [Parameter] public EventCallback<string> OnSortChanged { get; set; }
        protected async Task SortChanged(string orderBy)
        {
            this.PagingEntity.OrderBy = orderBy;
            await this.GetAsync();
        }

        [Parameter] public EventCallback<int> OnSelectedPage { get; set; }
        protected async Task SelectedPage(int page)
        {
            this.PagingEntity.PageNumber = page;

            await this.GetAsync();
        }

        protected virtual void LoadDataFail(Exception exception) { }
        protected virtual void LoadDataCategoryFail(Exception exception) { }

        protected virtual Task GetAsync() => Task.FromResult(default(object));
        protected virtual Task GetAsync(int id) => Task.FromResult(default(object));
        protected virtual Task InsertAsync() => Task.FromResult(default(object));
        protected virtual Task UpdateAsync() => Task.FromResult(default(object));
        protected virtual Task DeleteAsync() => Task.FromResult(default(object));
        protected virtual Task GetEntityCategoryAsync() => Task.FromResult(default(object));
    }
}
