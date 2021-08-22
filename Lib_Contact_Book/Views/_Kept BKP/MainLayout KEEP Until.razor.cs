//using System;
//using System.Collections.Generic;
//using System.Linq;

//using Constants;

//using Domain;

//using Microsoft.AspNetCore.Components;

//using PageFeatures;

//namespace Lib_Contact_Book.Views
//{
//    public partial class MainLayout : LayoutComponentBase, IDisposable
//    {
//        protected override void OnInitialized()
//        {
//            base.OnInitialized();

//            this.NavigationPageLinks = new List<PageLink>
//            {
//                new PageLink
//                {
//                    Route = "/",
//                    Link = "Home"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.ContactBook,
//                    Link = "Contact Book"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.MicroTech,
//                    Link = "MicroTech"
//                }
//            };

//            this.PageLinks = new List<PageLink>
//            {
//                new PageLink
//                {
//                    Route = "/",
//                    Link = "Home"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.ContactBook,
//                    Link = "Contact Book"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.MicroTech,
//                    Link = "MicroTech"
//                },
//                new PageLink
//                {
//                    Route = @PageRoute.ContactBookAdmin,
//                    Link = "ContactBook Admin"
//                },
//                new PageLink
//                {
//                    Route = @PageRoute.MicroTechAbout,
//                    Link = "MicroTech About"
//                }
//            };

//            this.FooterPageLinks = new List<PageLink>
//            {
//                new PageLink
//                {
//                    Route = "/",
//                    Link = "Home"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.ContactBook,
//                    Link = "Contact Book"
//                },
//                new PageLink
//                {
//                    Route = PageRoute.MicroTech,
//                    Link = "MicroTech"
//                }
//            };

//            this.MainCascadingValue = new MainCascadingValue(new ItemSelect(), "banner_background_image", "sort_container", "card_body grid_card_3", SharedData.Spread);
//        }

//        public MainCascadingValue MainCascadingValue { get; set; }

//        public List<PageLink> NavigationPageLinks { get; set; }

//        public List<PageLink> PageLinks { get; set; }

//        public List<PageLink> FooterPageLinks { get; set; }

//        public void Dispose()
//        {
//            this.MainCascadingValue.ItemSelect = null;
//            this.NavigationPageLinks = null;
//            this.PageLinks = null;
//            this.FooterPageLinks = null;
//            this.MainCascadingValue.BannerBackgroundImageCssClass = null;
//            this.MainCascadingValue.PositionCssClass = null;
//        }
//    }

//    // s gg
//    public partial class NavMenu
//    {
//        private bool collapseNavMenu = true;

//        private string NavMenuCssClass => this.collapseNavMenu ? "collapse" : null;

//        private void ToggleNavMenu() => this.collapseNavMenu = !this.collapseNavMenu;

//        private List<MenuData> menu;

//        private List<MenuData> Menu
//        {
//            get
//            {
//                if(this.menu is object)
//                {
//                    return this.menu;
//                }

//                this.menu = new List<MenuData>();
//                var assembly = System.Reflection.Assembly.GetExecutingAssembly();

//                foreach(var type in assembly.GetExportedTypes().Where(type => type.CustomAttributes.Any(attr => attr.AttributeType.Equals(typeof(RouteAttribute)))))
//                {
//                    var urlAttr = type.CustomAttributes.Where(at => at.AttributeType.Equals(typeof(RouteAttribute))).First();
//                    var titleAttr = type.CustomAttributes.Where(at => at.AttributeType.Equals(typeof(PageTitleAttribute))).FirstOrDefault();

//                    var url = urlAttr.ConstructorArguments.First().Value.ToString().TrimStart('/');
//                    var title = titleAttr?.ConstructorArguments.First().Value.ToString() ?? type.Name;
//                    this.menu.Add(new MenuData { RelativeUrl = url, MenuTitle = title });

//                }

//                this.menu = this.menu.OrderBy(md => md.RelativeUrl).ToList<MenuData>();

//                return this.menu;
//            }
//        }
//    }
//    // e gg
//}
