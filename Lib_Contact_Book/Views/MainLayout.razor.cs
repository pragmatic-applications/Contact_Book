using System.Collections.Generic;

using Constants;

using PageFeatures;

namespace Lib_Contact_Book.Views
{
    public partial class MainLayout
    {
        public List<PageLink> NavigationPageLinks
        {
            get
            {
                return new List<PageLink>
                {
                    new PageLink
                    {
                        Route = "/",
                        Link = "Home"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.Admin,
                        Link = "Admin"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.About,
                        Link = @PageRoute.About
                    }
                };
            }
        }

        public List<PageLink> PageLinks
        {
            get
            {
                return new List<PageLink>
                {
                    new PageLink
                    {
                        Route = "/",
                        Link = "Home"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.Admin,
                        Link = "Admin"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.About,
                        Link = @PageRoute.About
                    }
                };
            }
        }

        public List<PageLink> FooterPageLinks
        {
            get
            {
                return new List<PageLink>
                {
                    new PageLink
                    {
                        Route = "/",
                        Link = "Home"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.Admin,
                        Link = "Admin"
                    },
                    new PageLink
                    {
                        Route = @PageRoute.About,
                        Link = @PageRoute.About
                    }
                };
            }
        }

        //[Inject] public IBrowserService BrowserService { get; set; }
        //public BrowserDimension BrowserDimension { get; set; } = new();
        //public bool IsJavaScriptReady { get; set; }

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    await base.OnAfterRenderAsync(firstRender);

        //    if(firstRender)
        //    {
        //        await this.BrowserService.Resize();
        //        await this.BrowserService.OnWindowSize();

        //        var browserDimension = await this.BrowserService.GetDimensions();
        //        this.BrowserDimension.Width = browserDimension.Width;
        //        this.BrowserDimension.Height = browserDimension.Height;

        //        this.IsJavaScriptReady = true;

        //        this.StateHasChanged();
        //    }
        //}
    }
}
