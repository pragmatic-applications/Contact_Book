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

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
