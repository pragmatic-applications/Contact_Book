using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ContactEntityCategory
    {
        public int Id { get; set; }


        [Display(Name = "Category Name"), Required, MinLength(2, ErrorMessage = "Minimum length is 2")]
        public string Name { get; set; } = Enum.GetName(ContactCategoryType.Unspecified);


        public ICollection<ContactEntity> ContactEntities { get; set; }
    }
}
