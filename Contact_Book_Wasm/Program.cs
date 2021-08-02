using System;
using System.Net.Http;
using System.Threading.Tasks;

using Lib_Blazor_UI;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Contact_Book_Wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            DeployedState.IsDeployed = false;

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddClientServices();

            await builder.Build().RunAsync();
        }
    }
}
