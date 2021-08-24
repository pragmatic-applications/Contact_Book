using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace Lib_Blazor_Repeater
{
    public partial class Repeater<TEntity> : ComponentBase
    {
        [Parameter] public RenderFragment<TEntity> Entity { get; set; }
        [Parameter] public IEnumerable<TEntity> Entities { get; set; }
    }
}
