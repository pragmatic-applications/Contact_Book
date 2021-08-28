using System;

namespace Domain
{
    [AttributeUsage(validOn: AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class PageTitleAttribute : Attribute
    {
        public PageTitleAttribute(string pageTitle, bool isTopNavMenu = false, bool isBottomNavMenu = false)
        {
            this.PageTitle = pageTitle;
            this.IsTopNavMenu = isTopNavMenu;
            this.IsBottomNavMenu = isBottomNavMenu;
        }

        public string PageTitle { get; }
        public bool IsTopNavMenu { get; }
        public bool IsBottomNavMenu { get; }
    }
}
