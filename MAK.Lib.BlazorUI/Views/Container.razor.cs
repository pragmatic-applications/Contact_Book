using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Container<TEntity> : ComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        //[Parameter] public RenderFragment<TEntity> EntityContainer { get; set; }
        [Parameter] public TEntity UIEntityParameter { get; set; }
    }
}
