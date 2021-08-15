using Constants;

using Lib_Blazor_UI;

namespace Domain
{
    public class UrlHelper
    {
        public static string GetImagePath() => DeployedState.IsDeployed ? HttpConstant.Api_Image_Path_Deployed : HttpConstant.Api_Image_Path;
    }
}
