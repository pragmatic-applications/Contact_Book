using System;
using System.Net.Http;
using System.Threading.Tasks;

using Constants;

using Domain;

using Lib_Blazor_UI;

namespace HttpServices
{
    public class HttpContactEntityPostService : HttpEntityService<ContactEntity>
    {
        public HttpContactEntityPostService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;
            this.Url = ItemConstants.Url_S_Api_Items_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }

        public async Task PostEntityAsync(ContactEntity model) => await this.PostAsync(model);
    }
}
