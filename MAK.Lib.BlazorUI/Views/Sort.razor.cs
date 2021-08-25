using System.Threading.Tasks;

using Constants;

using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorUI.Views
{
    public partial class Sort : CoreComponent
    {
        [CascadingParameter(Name = nameof(CascadingData.SelectParameterValue))]
        public ISelect SelectCascadingParameter { get; set; }

        [CascadingParameter(Name = nameof(CascadingData.PositionCssClassParameterValue))]
        public string PositionCssClassCascadingParameter { get; set; }

        private async Task ApplySort(ChangeEventArgs eventArgs)
        {
            if(eventArgs.Value.ToString() == "-1") { return; }

            await this.OnSortChanged.InvokeAsync(eventArgs.Value.ToString());

            this.StateHasChanged();
        }
    }
}
