using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class HomeButtonDefault
    {
        [Parameter] public string UrlParameter { get; set; } = string.Empty;
    }
}
