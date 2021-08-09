using System.Threading.Tasks;

using Domain;

namespace Interfaces
{
    //public interface IContactEntityCategoryRepository : IRepository<ContactEntityCategory>
    //{
    //}

    public interface IContactEntityCategoryRepository : IRepository<ContactEntityCategory, int>
    {
    }
}
