using System;
using System.Collections.Generic;

using Constants;

using Domain;

using Microsoft.AspNetCore.Components;

using PageFeatures;

namespace Lib_Contact_Book.Views
{
    public partial class MainLayout : LayoutComponentBase, IDisposable
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.NavigationPageLinks = new List<PageLink>
            {
                new PageLink
                {
                    Route = "/",
                    Link = "Home"
                },
                new PageLink
                {
                    Route = PageRoute.ContactBook,
                    Link = "Contact Book"
                },
                new PageLink
                {
                    Route = PageRoute.MicroTech,
                    Link = "MicroTech"
                }
            };


            //this.PageLinks = new List<PageLink>
            //{
            //    new PageLink
            //    {
            //        Route = "/",
            //        Link = "Home"
            //    },
            //    new PageLink
            //    {
            //        Route = PageRoute.ContactBook,
            //        Link = "Contact Book"
            //    },
            //    new PageLink
            //    {
            //        Route = PageRoute.MicroTech,
            //        Link = "MicroTech"
            //    },
            //    new PageLink
            //    {
            //        Route = @PageRoute.ContactBookAdmin,
            //        Link = "ContactBook Admin"
            //    },
            //    new PageLink
            //    {
            //        Route = @PageRoute.MicroTechAbout,
            //        Link = "MicroTech About"
            //    }
            //};

            this.FooterPageLinks = new List<PageLink>
            {
                new PageLink
                {
                    Route = "/",
                    Link = "Home"
                },
                new PageLink
                {
                    Route = PageRoute.ContactBook,
                    Link = "Contact Book"
                },
                new PageLink
                {
                    Route = PageRoute.MicroTech,
                    Link = "MicroTech"
                }
            };

            this.MainCascadingValue = new MainCascadingValue(new ItemSelect(), "banner_background_image", "sort_container", "card_body grid_card_3", SharedData.Spread);
        }

        public MainCascadingValue MainCascadingValue { get; set; }

        public List<PageLink> NavigationPageLinks { get; set; }

        //public List<PageLink> PageLinks { get; set; }

        public List<PageLink> FooterPageLinks { get; set; }

        public void Dispose()
        {
            this.MainCascadingValue.ItemSelect = null;
            this.NavigationPageLinks = null;
            //this.PageLinks = null;
            this.FooterPageLinks = null;
            this.MainCascadingValue.BannerBackgroundImageCssClass = null;
            this.MainCascadingValue.PositionCssClass = null;
        }
    }
}
