using System;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class RenderModeSwitch : ComponentBase
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        private bool server;

        protected override void OnInitialized()
        {
            this.server = new Uri(this.NavigationManager.Uri).Query.Contains("server");
        }

        private bool Server
        {
            get => this.server;

            set
            {
                if(this.server == value)
                {
                    return;
                }

                this.server = value;
                var uriBuilder = new UriBuilder(this.NavigationManager.Uri);

                if(this.server)
                {
                    uriBuilder.Query = "server";
                }
                else
                {
                    uriBuilder.Query = string.Empty;
                }

                this.NavigationManager.NavigateTo(uriBuilder.ToString(), forceLoad: true);
            }
        }
    }
}
