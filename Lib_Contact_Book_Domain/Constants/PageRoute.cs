namespace Constants
{
    public class PageRoute
    {
        public const string Contact = "contact";
        //public const string ContactFeedback = "contact-feedback";
        public const string Guest = "guest";

        public const string ContactBookAbout = "ContactBook/About";
        public const string Security = "Security";
        public const string Web = "Web";
        public const string DigitalMarketing = "Digital-Marketing";

        public const string LegalStuff = "legal-stuff";

        public const string PrivacyPolicy = "privacy-policy";
        public const string TermsAndConditions = "terms-and-conditions";


        //Contact_Book
        public const string ContactBook = "ContactBook";

        public const string ContactBookAdmin = "ContactBook/Admin";
        public const string ContactBookAdminCreate = "ContactBook/Admin/Create";

        public const string ContactBookAdminDelete = "ContactBook/Admin/Delete/{id:int}";
        public const string S_AdminDelete = "/ContactBook/Admin/Delete";
        public const string S_AdminDelete_S = "/ContactBook/Admin/Delete/";

        public const string ContactBookAdminDetails = "ContactBook/Admin/Details/{id:int}";
        public const string S_AdminDetails = "/ContactBook/Admin/Details";
        public const string S_AdminDetails_S = "/ContactBook/Admin/Details/";

        public const string ContactBookAdminUpdate = "ContactBook/Admin/Update/{id:int}";
        public const string S_AdminUpdate = "/ContactBook/Admin/Update";
        public const string S_AdminUpdate_S = "/ContactBook/Admin/Update/";

        //==============
        //MicroTech
        public const string MicroTech = "MicroTech";

        //Contacts
        public const string MicroTechContact = "MicroTech/Contact";
        public const string MicroTechContactFeedback = "MicroTech/Contact-Feedback";
        public const string MicroTechGuest = "MicroTech/Guest";

        //Info
        public const string MicroTechAbout = "MicroTech/About";
        public const string MicroTechSecurity = "MicroTech/Security";
        public const string MicroTechWeb = "MicroTech/Web";
        public const string MicroTechDigitalMarketing = "MicroTech/Digital-Marketing";
    }
}
