//using System.Collections.Generic;

//using Domain;

//using HttpServices;

//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//using PageFeatures;

//namespace Services
//{
//    public static class Injector
//    {
//        public static IServiceCollection InjectCore(this IServiceCollection services, IConfiguration configuration = null)
//        {
//            services.AddScoped<AppContact>();
//            services.AddScoped<List<AppContact>>();
//            services.AddHttpClient<HttpContactService>();
//            services.AddHttpClient<HttpResourceService>();

//            //services.AddHttpClient<ImageUploaderService>();

//            services.AddHttpClient<HttpImageUploaderService>();

//            services.AddScoped<PagerData>();
//            services.AddScoped<List<PagerData>>();
//            services.AddScoped<PagingEntity>();
//            services.AddScoped<List<PagingEntity>>();

//            services.AddHttpClient<HttpResourceService>();

//            //services.AddScoped<NavigationJSI>();
//            //services.AddScoped<IBrowserService, BrowserService>();

//            return services;
//        }
//    }
//}
