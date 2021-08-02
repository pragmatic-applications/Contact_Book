namespace Constants
{
    // Todo: Update these...
    public class PageRoute
    {
        public const string Contact = "contact";
        public const string ContactFeedback = "contact-feedback";
        public const string Guest = "guest";

        public const string About = "About";
        public const string Security = "Security";
        public const string Web = "Web";
        public const string DigitalMarketing = "Digital-Marketing";

        public const string LegalStuff = "legal-stuff";

        public const string PrivacyPolicy = "privacy-policy"; // PageRoute.PrivacyPolicy
        public const string TermsAndConditions = "terms-and-conditions"; // PageRoute.TermsAndConditions



        public const string Admin = "Admin";
        public const string AdminCreate = "Admin/Create";

        public const string AdminDelete = "Admin/Delete/{id:int}";
        public const string S_AdminDelete = "/Admin/Delete";
        public const string S_AdminDelete_S = "/Admin/Delete/";

        public const string AdminDetails = "Admin/Details/{id:int}";
        public const string S_AdminDetails = "/Admin/Details";
        public const string S_AdminDetails_S = "/Admin/Details/";

        public const string AdminUpdate = "Admin/Update/{id:int}";
        public const string S_AdminUpdate = "/Admin/Update";
        public const string S_AdminUpdate_S = "/Admin/Update/";
    }
}
