using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using PageFeatures;

namespace HttpServices
{
    public class HttpContactService : HttpEntityService<AppContact>
    {
        public HttpContactService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ClientConstant.Url_S_Api_Contacts_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task<PagingResponse<AppContact>> GetEntitiesAsync(PagingEntity entityParameter) => await this.GetAsync(entityParameter: entityParameter);

        public async Task<List<AppContact>> GetEntitiesAsync() => await this.GetAsync();

        public async Task<AppContact> GetEntityByIdAsync(int id) => await this.GetAsync(id);

        public async Task PutEntityAsync(int id, AppContact model) => await this.PutAsync(id, model);

        public async Task PostEntityAsync(AppContact model) => await this.PostAsync(model);

        public async Task DeleteEntityAsync(int id) => await this.DeleteAsync(id);

        public async Task DoActionAsync(AppContact model) => await this.PostAsync(model);
    }
}
