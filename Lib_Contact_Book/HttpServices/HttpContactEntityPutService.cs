using System;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using DTOs;

using Lib_Blazor_UI;

namespace HttpServices
{
    public class HttpContactEntityPutService : HttpEntityService<ContactEntityDtoUpdate>
    {
        public HttpContactEntityPutService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ItemConstants.Url_S_Api_Items_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task PutEntityAsync(int id, ContactEntityDtoUpdate model) => await this.PutAsync(id, model);
    }
}
