using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using DTOs;

using PageFeatures;

namespace HttpServices
{
    public class HttpContactEntityService : HttpEntityService<ContactEntityDto>
    {
        public HttpContactEntityService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ItemConstants.Url_S_Api_Items_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task<PagingResponse<ContactEntityDto>> GetEntitiesAsync(PagingEntity entityParameter) => await this.GetAsync(entityParameter: entityParameter);

        public async Task<List<ContactEntityDto>> GetEntitiesAsync() => await this.GetAsync();

        public async Task<ContactEntityDto> GetEntityByIdAsync(int id) => await this.GetAsync(id);

        public async Task PutEntityAsync(int id, ContactEntityDto model) => await this.PutAsync(id, model);

        public async Task PostEntityAsync(ContactEntityDto model) => await this.PostAsync(model);

        public async Task DeleteEntityAsync(int id) => await this.DeleteAsync(id);
    }
}
