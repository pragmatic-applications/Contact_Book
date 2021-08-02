using System.Threading.Tasks;

using Database;

using Interfaces;

namespace Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationDbContext applicationDbContext, IContactEntityRepository contactEntityRepository, IContactEntityCategoryRepository contactEntityCategoryRepository)
        {
            this.applicationDbContext = applicationDbContext;

            this.ContactEntityRepository = contactEntityRepository;

            this.ContactEntityCategoryRepository = contactEntityCategoryRepository;
        }

        private readonly ApplicationDbContext applicationDbContext;

        public IContactEntityRepository ContactEntityRepository { get; }

        public IContactEntityCategoryRepository ContactEntityCategoryRepository { get; }

        public async Task SaveChangesAsync() => await this.applicationDbContext.SaveChangesAsync();
    }
}
