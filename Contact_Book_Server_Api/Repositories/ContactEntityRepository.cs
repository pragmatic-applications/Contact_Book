using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Database;

using Domain;

using Extensions;

using Interfaces;

using Microsoft.EntityFrameworkCore;

using PageFeatures;

namespace Repositories
{
    public class ContactEntityRepository : Repository<ContactEntity, int>, IContactEntityRepository
    {
        public ContactEntityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedList<ContactEntity>> GetPagedList(PagingEntity entityParameter)
        {
            var items = await this.ApplicationDbContext.ContactEntities
            .Search(entityParameter.SearchTerm)
            .Sort(entityParameter.OrderBy)
            .ToListAsync();

            return PagedList<ContactEntity>.ToPagedList(items, entityParameter.PageNumber, entityParameter.PageSize);
        }

        public IQueryable<ContactEntity> Get(int id) => this.ApplicationDbContext.Set<ContactEntity>().Where(item => item.Id == id).AsNoTracking();

        public async Task<IEnumerable<ContactEntity>> GetAllAsync() => await this.Get().OrderBy(item => item.ContactName).ToListAsync();

        public async Task<ContactEntity> GetDetailsAsync(int id)
        {
            return await this.Get(item => item.Id.Equals(id)).Include(c => c.ContactEntityCategory).FirstOrDefaultAsync();
        }
    }
}
