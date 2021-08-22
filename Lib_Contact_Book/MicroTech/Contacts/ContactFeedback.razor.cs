using System.Collections.Generic;

using Constants;

namespace Lib_Contact_Book.MicroTech.Contacts
{
    public partial class ContactFeedback : ContactBase
    {
        public List<string> Images
        {
            get
            {
                if(!string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path))
                {
                    return new List<string>
                    {
                        ClientConstant.Static_Content_Path + "Images/Home/Home03.jpg"
                    };
                }

                return new List<string>
                {
                    "Images/Home/Home03.jpg"
                };
            }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            this.BannerTitleValue = "Feedback";
        }
    }
}
