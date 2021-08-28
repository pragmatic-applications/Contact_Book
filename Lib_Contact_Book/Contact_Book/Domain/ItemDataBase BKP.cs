//using Constants;

//using DTOs;

//using Microsoft.AspNetCore.Components;

//namespace Domain
//{
//    public class ItemDataBase : Component
//    {
//        [CascadingParameter(Name = nameof(CascadingData.EntityParameterValue))]
//        public ContactEntityDto EntityCascadingParameter { get; set; }

//        public string IsDone => this.EntityCascadingParameter.IsChecked ? "Yes" : "No";
//        public string EntryId => this.EntityCascadingParameter.Id < 10 ? $"0{this.EntityCascadingParameter.Id}" : $"{this.EntityCascadingParameter.Id}";
//    }
//}
