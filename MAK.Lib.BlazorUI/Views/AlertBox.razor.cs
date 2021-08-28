using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class AlertBox
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
