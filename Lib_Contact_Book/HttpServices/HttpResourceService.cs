using System;
using System.Net.Http;

using Constants;

using Domain;

namespace HttpServices
{
    public class HttpResourceService : HttpEntityServiceLite
    {
        public HttpResourceService(HttpClient httpClient) : base(httpClient)
        {
            httpClient.BaseAddress = DeployedState.IsDeployed ? new Uri(ClientConstant.Url_Api_Base_Deployed) : new Uri(ClientConstant.Url_Api_Base);

            this.HttpClient = httpClient;

            this.Url = ClientConstant.Url_S_Api_Resources_S;
            this.UrlApiUploader = HttpConstant.Url_S_Api_Upload;
        }
    }
}
