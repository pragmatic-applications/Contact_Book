//using System;

//using Constants;

//using Domain;

//using Microsoft.AspNetCore.Components;

//namespace MAK.Lib.BlazorUI.CardViews
//{
//    public partial class CardBody<TEntity> : Component
//    {
//        [Parameter]
//        public RenderFragment CardTitle { get; set; }

//        [Parameter]
//        public RenderFragment CardText { get; set; }

//        [Parameter]
//        public RenderFragment CardLink { get; set; }

//        [CascadingParameter(Name = nameof(CascadingData.CardLinkCascadingValue))]
//        public string CardLinkCascadingParameter { get; set; }

//        [CascadingParameter(Name = nameof(CascadingData.CardBodyCssCascadingValue))]
//        public string CardBodyCssCascadingParameter { get; set; }

//        //??
//        [Parameter]
//        public RenderFragment<TEntity> ExtraContent { get; set; }

//        [Parameter]
//        public TEntity Entity { get; set; }
//        //??
//    }
//}
