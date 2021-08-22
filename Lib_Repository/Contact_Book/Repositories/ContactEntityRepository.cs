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

        //// Orig - YYY
        //public async Task<ContactEntity> GetAsync(int id) => await this.ApplicationDbContext.ContactEntities.Include(item => item.ContactEntityCategory).FirstOrDefaultAsync(item => item.Id == id);
        public async Task<ContactEntity> GetAsync(int id) => await this.Get().Include(item => item.ContactEntityCategory).FirstOrDefaultAsync(item => item.Id == id);
    }
}
