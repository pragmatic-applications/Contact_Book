using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public class MvcInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddControllers();
            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);

            return services;
        }
    }
}
