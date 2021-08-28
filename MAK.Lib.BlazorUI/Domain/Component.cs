using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace Domain
{
    public class Component : ComponentBase
    {
        public bool IsDebugConsole { get; set; } = true;

        public static int EntityId = 0;
        public string ButtonText { get; set; } = "Save";

        public FormMode FormMode { get; set; } = FormMode.Create;
        public string FormTitle { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }

        [Parameter]
        public string CardLinkParameter { get; set; }

        [Parameter] public int IdParameter { get; set; } = 0;
        [Parameter] public string UrlParameter { get; set; } = string.Empty;

        [Inject] public NavigationManager NavigationManager { get; set; }

        public string CurrentTitle { get; set; } = string.Empty;
        public string PageToNavigateTo { get; set; } = string.Empty;

        [Parameter] public PagerData PagerDataParameter { get; set; }

        [Parameter] public string AdminTitleParameter { get; set; }
        [Parameter] public string HomeTitleParameter { get; set; }
        [Parameter] public string AboutTitleParameter { get; set; }
        [Parameter] public string ItemTitleParameter { get; set; }
        [Parameter] public string ProductTitleParameter { get; set; }
        [Parameter] public string StudentTitleParameter { get; set; }
        [Parameter] public string ShopTitleParameter { get; set; }

        [Parameter] public string ButtonLogoValueParameter { get; set; }

        [Parameter] public string TitleParameter { get; set; }

        public string HeadTitleValue { get; set; }

        [Parameter] public string BannerTitleParameter { get; set; }
        public string BannerTitleValue { get; set; }
        public string HeaderTitle { get; set; }

        [Parameter] public string AppNameParameter { get; set; }
        public string AppNameValue { get; set; }
        public string AppName { get; set; }

        [CascadingParameter(Name = "ItemTitleValue")] public string ItemTitleCParameter { get; set; }
        [CascadingParameter(Name = "ProductTitleValue")] public string ProductTitleCParameter { get; set; }
        [CascadingParameter(Name = "StudentTitleValue")] public string StudentTitleCParameter { get; set; }
        [CascadingParameter(Name = "AdminTitleValue")] public string AdminTitleCParameter { get; set; }
        [CascadingParameter(Name = "HomeTitleValue")] public string HomeTitleCParameter { get; set; }
        [CascadingParameter(Name = "AboutTitleValue")] public string AboutTitleCParameter { get; set; }

        [CascadingParameter(Name = "ShopTitleValue")] public string ShopTitleCParameter { get; set; }
        [CascadingParameter(Name = "TitleValue")] public string TitleCParameter { get; set; }
        [CascadingParameter] public string TitleCascadingParameter { get; set; }

        [Parameter] public bool IsPageIndexParameter { get; set; } = false;

        public string UrlUpdate { get; set; }
        public string UrlDelete { get; set; }
        public string Url { get; set; }
        public string UrlDetail { get; set; }
        public string UrlEdit { get; set; }

        public bool IsLoading { get; set; }
        public bool IsError { get; set; }
        protected int ImageCount { get; set; } = 0;
    }
}
