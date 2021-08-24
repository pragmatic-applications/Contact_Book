using System.Collections.Generic;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class Card<TEntity> : ComponentBase, ICard<TEntity>, IHandleChildStateChange
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)] public Dictionary<string, object> Attributes { get; set; }

        private readonly List<CardBody<TEntity>> bodies = new();
        public void AddBody(CardBody<TEntity> body)
        {
            this.bodies.Add(body);
            this.StateHasChanged();
        }

        private CardHeader<TEntity> header;
        public void SetHeader(CardHeader<TEntity> header)
        {
            this.header = header;
            this.StateHasChanged();
        }

        private CardFooter<TEntity> footer;
        public void SetFooter(CardFooter<TEntity> footer)
        {
            this.footer = footer;
            this.StateHasChanged();
        }

        public void ChildStateChanged() => this.StateHasChanged();
    }
}
