using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUnitOfWork
    {
        IContactEntityRepository ContactEntityRepository { get; }

        IContactEntityCategoryRepository ContactEntityCategoryRepository { get; }

        IAppRepository AppRepository { get; }
        IDevUserRepository DevUserRepository { get; }

        Task SaveChangesAsync();
    }
}
