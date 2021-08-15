using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class ContactEntityDtoUpdate
    {
        [Display(Name = "Contact Name"), MinLength(2)]
        public string ContactName { get; set; }


        [Display(Name = "First Name"), MinLength(2)]
        public string FirstName { get; set; }


        [Display(Name = "Last Name"), MinLength(2)]
        public string LastName { get; set; }


        [Display(Name = "Email"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Phone"), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Display(Name = "Contact Address"), MinLength(2), MaxLength(200)]
        public string Address { get; set; }


        [Display(Name = "Image")]
        public string Image { get; set; } = "Default.png";


        [Display(Name = "Is Checked")]
        public bool? IsChecked { get; set; }


        [Display(Name = "Category Name")]
        public int? ContactEntityCategoryId { get; set; }
    }
}
