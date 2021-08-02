using System;
using System.ComponentModel.DataAnnotations;

using Domain;

namespace DTOs
{
    public class ContactEntityDto
    {
        public int Id { get; set; }


        [Display(Name = "Contact Name"), Required, MinLength(2)]
        public string ContactName { get; set; }


        private string firstName;

        [Display(Name = "First Name"), MinLength(2)]
        public string FirstName
        {
            get
            {
                if(string.IsNullOrWhiteSpace(this.firstName))
                {
                    this.firstName = this.ContactName;
                }

                return this.firstName;
            }

            set
            {
                if(string.IsNullOrWhiteSpace(this.firstName))
                {
                    this.firstName = this.ContactName;
                }

                this.firstName = value;
            }
        }
        //[Display(Name = "First Name"), MinLength(2)]
        //public string FirstName { get; set; }


        [Display(Name = "Last Name"), MinLength(2)]
        public string LastName { get; set; }


        [Display(Name = "Email"), Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Phone"), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Display(Name = "Contact Address"), MinLength(2), MaxLength(200)]
        public string Address { get; set; }


        [Display(Name = "Image")]
        public string Image { get; set; } = "Default.png";


        [Display(Name = "Is Checked")]
        public bool IsChecked { get; set; } = false;


        [Display(Name = "Created Date")]
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;


        [Display(Name = "Category Name")]
        public int ContactEntityCategoryId { get; set; } = (int)ContactCategoryType.Unspecified;
        public ContactEntityCategory ContactEntityCategory { get; set; }
    }
}
