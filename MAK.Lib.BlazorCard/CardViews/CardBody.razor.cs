using System.Collections.Generic;

using Domain;

using Interfaces;

using Microsoft.AspNetCore.Components;

namespace MAK.Lib.BlazorCard.CardViews
{
    public partial class CardBody<TEntity> : ChildElement<ICard<TEntity>>, ICardBody<TEntity>
    {
        protected override void Register(ICard<TEntity> parent) => parent.AddBody(this);

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private CardTitle<TEntity> title;
        public void SetTitle(CardTitle<TEntity> title)
        {
            this.title = title;
            this.StateHasChanged();
        }

        private readonly List<CardText<TEntity>> texts = new();

        public void AddText(CardText<TEntity> text)
        {
            this.texts.Add(text);
            this.StateHasChanged();
        }

        private readonly List<CardLink<TEntity>> links = new();

        public void AddLink(CardLink<TEntity> link)
        {
            this.links.Add(link);
            this.StateHasChanged();
        }

        [Parameter]
        public string Css { get; set; }

        public override RenderFragment RenderContent => (builder =>
        {
            var i = 0;
            builder.OpenElement(i++, "div");
            builder.AddAttribute(i++, "class", this.Css);

            if(this.title != null)
            {
                builder.AddContent(i++, this.title.RenderContent);
            }

            foreach(var text in this.texts)
            {
                builder.AddContent(i++, text.RenderContent);
            }

            foreach(var link in this.links)
            {
                builder.AddContent(i++, link.RenderContent);
            }

            builder.CloseElement();
        });
    }
}
