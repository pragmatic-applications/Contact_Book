using Helpers;

using Lib_Blazor_UI;

namespace Domain
{
    public class ClientBase : AppComponent
    {
        public ListCounter ListCounter { get; set; } = new();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.AppNameValue = "MicroTech";
        }
    }
}
