using System.Threading.Tasks;

using Domain;

namespace Interfaces
{
    public interface IContactEntityRepository : IRepository<ContactEntity, int>, IPagedList<ContactEntity>
    {
        Task<ContactEntity> GetAsync(int id);
    }
}
