using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ContactEntity
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

        [Display(Name = "Last Name"), MinLength(2)]
        public string LastName { get; set; }

        //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        [Display(Name = "Email"), Required, EmailAddress]
        public string Email { get; set; }


        //const string PhoneNumberPattern = @"^0(\d ?){10}$"; // Simple and works.
        // Best e.g. (####) ### ####
        const string PhoneNumberPattern = @"^\s*(([+]\s?\d[-\s]?\d|0)?\s?\d([-\s]?\d){9}|[(]\s?\d([-\s]?\d)+\s*[)]([-\s]?\d)+)\s*$"; 

        [Display(Name = "Phone"), Phone, RegularExpression(PhoneNumberPattern, ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Contact Address"), MinLength(2), MaxLength(200)]
        public string Address { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; } = "Default.png";

        [Display(Name = "Is Checked")]
        public bool IsChecked { get; set; } = false;

        [Display(Name = "Created Date")]
        public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

        [Display(Name = "Contact Category")]
        public int ContactEntityCategoryId { get; set; } = (int)ContactCategoryType.Unspecified;
        public ContactEntityCategory ContactEntityCategory { get; set; }
    }
}
