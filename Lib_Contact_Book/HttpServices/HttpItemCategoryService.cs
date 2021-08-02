using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using Lib_Blazor_UI;

namespace HttpServices
{
    public class HttpItemCategoryService : HttpEntityService<ContactEntityCategory>
    {
        public HttpItemCategoryService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ItemConstants.Url_S_Api_ItemCategories_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task<List<ContactEntityCategory>> GetEntitiesAsync() => await base.GetAsync();

        public async Task<ContactEntityCategory> GetEntityByIdAsync(int id) => await this.GetAsync(id);

        public async Task AddEntityAsync(ContactEntityCategory model) => await this.PostAsync(model);

        public async Task EditEntityAsync(int id, ContactEntityCategory model) => await this.PutAsync(id, model);

        public async Task DeleteEntityAsync(int id) => await this.DeleteAsync(id);
    }
}
