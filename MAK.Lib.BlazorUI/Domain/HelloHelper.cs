using Microsoft.JSInterop;

namespace Domain
{
  public class HelloHelper
  {
    public HelloHelper(string name)
    {
      this.Name = name;
    }

    public string Name { get; set; }

    [JSInvokable]
    public string SayHello() => $"Hello, {this.Name}!";
  }
}
