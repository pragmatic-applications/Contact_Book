namespace Domain
{
  public class StyleManager
  {
    public static string CssRuleValue { get; set; }

    public static string AddCssRule(string cssValue)
    {
      return CssRuleValue += $" {cssValue}";
    }

    public static string SetCssValue(string cssValue)
    {
      CssRuleValue = cssValue;

      return cssValue;
    }
  }
}
