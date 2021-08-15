using Domain;

using Interfaces;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Repositories;

namespace Services
{
    public class RepositoryInjector : IService
    {
        public IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddScoped<IContactEntityCategoryRepository, ContactEntityCategoryRepository>();
            services.AddScoped<IRepository<ContactEntityCategory, int>, Repository<ContactEntityCategory, int>>();

            services.AddScoped<IContactEntityRepository, ContactEntityRepository>();
            services.AddScoped<IRepository<ContactEntity, int>, Repository<ContactEntity, int>>();

            services.AddScoped<IAppRepository, AppRepository>();
            services.AddScoped<IRepository<AppModel, int>, Repository<AppModel, int>>();

            services.AddScoped<IDevUserRepository, DevUserRepository>();
            services.AddScoped<IRepository<DevUser, int>, Repository<DevUser, int>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
