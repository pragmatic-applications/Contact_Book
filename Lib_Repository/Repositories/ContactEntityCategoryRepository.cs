using Database;

using Domain;

using Interfaces;

namespace Repositories
{
    public class ContactEntityCategoryRepository : Repository<ContactEntityCategory, int>, IContactEntityCategoryRepository
    {
        public ContactEntityCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
