using System.Collections.Generic;

using Constants;

using Domain;

namespace Lib_Contact_Book.MicroTech.Marketing
{
    [PageTitle("Marketing")]
    public partial class Index : ClientBase
    {
        protected string GeneralEnglishImg => !string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path) ? ClientConstant.Static_Content_Path + "Images/AEE/RoundAEE/07.jpg" : "Images/AEE/RoundAEE/07.jpg";

        protected string YoungLearnersImg => !string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path) ? ClientConstant.Static_Content_Path + "Images/AEE/RoundAEE/01.jpg" : "Images/AEE/RoundAEE/01.jpg";

        protected string BusinessEnglishImg => !string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path) ? ClientConstant.Static_Content_Path + "Images/AEE/RoundAEE/02.jpg" : "Images/AEE/RoundAEE/02.jpg";

        protected string TravelEnglishImg => !string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path) ? ClientConstant.Static_Content_Path + "Images/AEE/RoundAEE/04.jpg" : "Images/AEE/RoundAEE/04.jpg";

        protected List<string> Images
        {
            get
            {
                return !string.IsNullOrWhiteSpace(ClientConstant.Static_Content_Path) ? new List<string>
                {
                    ClientConstant.Static_Content_Path + "Images/AEE/Round/07.jpg"
                }
                : new List<string>
                {
                    "Images/AEE/Round/07.jpg"
                };
            }
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.BannerTitleValue = "MicroTech Marketing";
        }
    }
}
