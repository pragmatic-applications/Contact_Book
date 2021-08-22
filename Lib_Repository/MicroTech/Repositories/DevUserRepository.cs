
using Database;

using Domain;

using Interfaces;

namespace Repositories
{
    public class DevUserRepository : Repository<DevUser, int>, IDevUserRepository
    {
        public DevUserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
