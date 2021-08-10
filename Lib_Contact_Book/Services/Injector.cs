using System.Collections.Generic;

using Domain;

using DTOs;

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
            services.AddScoped<ContactEntityCategory>();
            services.AddScoped<List<ContactEntityCategory>>();

            services.AddScoped<ITaskService<ContactEntityDto>, ContactEntityTaskService>();
            services.AddScoped<ContactEntityDto>();
            services.AddScoped<List<ContactEntityDto>>();
            services.AddHttpClient<HttpContactEntityService>();

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
