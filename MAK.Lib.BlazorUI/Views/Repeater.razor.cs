using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Repeater<TEntity> : ComponentBase
    {
        [Parameter] public RenderFragment<TEntity> Entity { get; set; }
        [Parameter] public IEnumerable<TEntity> Entities { get; set; }
    }
}
