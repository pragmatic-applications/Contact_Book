using System.Threading;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Search
    {
        private Timer timer;

        public string SearchTerm { get; set; }

        [Parameter] public EventCallback<string> OnSearchChanged { get; set; }

        private void SearchChanged()
        {
            if(this.timer != null)
            {
                this.timer.Dispose();
            }

            this.timer = new Timer(this.OnTimerElapsed, null, 500, 0);
        }

        private void OnTimerElapsed(object sender)
        {
            this.OnSearchChanged.InvokeAsync(this.SearchTerm);
            this.timer.Dispose();
        }
    }
}
