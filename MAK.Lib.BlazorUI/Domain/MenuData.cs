namespace Domain
{
    public class MenuData
    {
        public string RelativeUrl { get; set; }
        public string MenuTitle { get; set; }

        public override string ToString() => $"Url: {this.RelativeUrl} Title: {this.MenuTitle}";
    }
}
