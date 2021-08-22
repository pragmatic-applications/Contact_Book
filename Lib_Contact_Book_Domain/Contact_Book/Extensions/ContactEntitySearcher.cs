using System.Linq;
using System.Linq.Dynamic.Core;

using Domain;

namespace Extensions
{
    public static class ContactEntitySearcher
    {
        public static IQueryable<ContactEntity> Search(this IQueryable<ContactEntity> models, string searchTearm)
        {
            if(string.IsNullOrWhiteSpace(searchTearm))
            {
                return models;
            }

            var searchTermLowerCase = searchTearm.Trim().ToLower();

            return models.Where(e => e.ContactName.ToLower().Contains(searchTermLowerCase));
        }
    }
}
