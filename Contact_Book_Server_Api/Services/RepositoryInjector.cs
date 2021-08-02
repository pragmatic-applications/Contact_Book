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
            services.AddScoped<IRepository<ContactEntityCategory>, Repository<ContactEntityCategory>>();

            services.AddScoped<IContactEntityRepository, ContactEntityRepository>();
            services.AddScoped<IRepository<ContactEntity>, Repository<ContactEntity>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
