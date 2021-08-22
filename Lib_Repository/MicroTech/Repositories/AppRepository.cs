using Database;

using Domain;

using Interfaces;

namespace Repositories
{
    public class AppRepository : Repository<AppModel, int>, IAppRepository
    {
        public AppRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
