using Interfaces;

using Microsoft.AspNetCore.Components;

namespace Domain
{
    public abstract class ChildElement<TParent> : ComponentBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            if(this.Parent != null)
            {
                this.Register(this.Parent);
            }
        }

        protected new void StateHasChanged()
        {
            base.StateHasChanged();

            var cscHandler = this.Parent as IHandleChildStateChange;

            if(cscHandler != null)
            {
                cscHandler.ChildStateChanged();
            }
        }

        [CascadingParameter]
        private TParent Parent { get; set; }

        protected abstract void Register(TParent parent);
        public abstract RenderFragment RenderContent { get; }
    }
}
