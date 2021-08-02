using System.Collections.Generic;

using Domain;

using HttpServices;

using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using PageFeatures;

namespace Services
{
    public static class Injector
    {
        public static IServiceCollection InjectCore(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddScoped<ITaskService<ContactEntity>, TaskService>();

            services.AddScoped<ContactEntity>();
            services.AddScoped<List<ContactEntity>>();

            services.AddScoped<ContactEntityCategory>();
            services.AddScoped<List<ContactEntityCategory>>();

            services.AddHttpClient<HttpItemService>();
            services.AddHttpClient<HttpItemCategoryService>();

            services.AddHttpClient<HttpImageUploaderService>();

            services.AddScoped<PagerData>();
            services.AddScoped<List<PagerData>>();
            services.AddScoped<PagingEntity>();
            services.AddScoped<List<PagingEntity>>();

            services.AddHttpClient<HttpResourceService>();

            //services.AddScoped<NavigationJSI>();
            //services.AddScoped<IBrowserService, BrowserService>();

            return services;
        }
    }
}
