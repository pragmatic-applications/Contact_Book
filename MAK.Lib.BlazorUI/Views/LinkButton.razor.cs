using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class LinkButton : ComponentBase
    {
        [Parameter]
        public string Url { get; set; }

        [Parameter]
        public string Css { get; set; }

        [Parameter]
        public string Alt { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment UrlLink { get; set; }

        [Parameter]
        public string LinkText { get; set; }
    }
}
