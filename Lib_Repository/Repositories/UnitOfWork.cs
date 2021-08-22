using System.Threading.Tasks;

using Database;

using Interfaces;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext applicationDbContext, IContactEntityRepository contactEntityRepository, IContactEntityCategoryRepository contactEntityCategoryRepository, IAppRepository aeeRepository, IDevUserRepository devUserRepository)
        {
            this.applicationDbContext = applicationDbContext;

            this.ContactEntityRepository = contactEntityRepository;

            this.ContactEntityCategoryRepository = contactEntityCategoryRepository;

            this.AppRepository = aeeRepository;
            this.DevUserRepository = devUserRepository;
        }

        private readonly ApplicationDbContext applicationDbContext;

        public IContactEntityRepository ContactEntityRepository { get; }

        public IContactEntityCategoryRepository ContactEntityCategoryRepository { get; }

        public IAppRepository AppRepository { get; }
        public IDevUserRepository DevUserRepository { get; }

        public async Task SaveChangesAsync() => await this.applicationDbContext.SaveChangesAsync();
    }
}
