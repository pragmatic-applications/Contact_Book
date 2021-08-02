using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using Lib_Blazor_UI;

using PageFeatures;

namespace HttpServices
{
    public class HttpItemService : HttpEntityService<ContactEntity>
    {
        public HttpItemService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ItemConstants.Url_S_Api_Items_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task<PagingResponse<ContactEntity>> GetEntitiesAsync(PagingEntity entityParameter) => await this.GetAsync(entityParameter: entityParameter);

        public async Task<List<ContactEntity>> GetEntitiesAsync() => await this.GetAsync();

        public async Task<ContactEntity> GetEntityByIdAsync(int id) => await this.GetAsync(id);

        public async Task AddEntityAsync(ContactEntity model) => await this.PostAsync(model);

        public async Task EditEntityAsync(int id, ContactEntity model) => await this.PutAsync(id, model);

        public async Task DeleteEntityAsync(int id) => await this.DeleteAsync(id);
    }
}
