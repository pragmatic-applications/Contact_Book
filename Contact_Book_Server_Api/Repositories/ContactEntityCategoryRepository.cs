
using Database;

using Domain;

using Interfaces;

namespace Repositories
{
    public class ContactEntityCategoryRepository : Repository<ContactEntityCategory>, IContactEntityCategoryRepository
    {
        public ContactEntityCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
    
    
}
