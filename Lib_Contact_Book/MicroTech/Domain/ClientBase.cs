using Helpers;

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
