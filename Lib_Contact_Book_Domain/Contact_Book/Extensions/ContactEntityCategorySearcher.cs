using System.Linq;
using System.Linq.Dynamic.Core;

using Domain;

namespace Extensions
{
    public static class ContactEntityCategorySearcher
    {
        public static IQueryable<ContactEntityCategory> Search(this IQueryable<ContactEntityCategory> models, string searchTearm)
        {
            if(string.IsNullOrWhiteSpace(searchTearm))
            {
                return models;
            }

            var searchTermLowerCase = searchTearm.Trim().ToLower();

            return models.Where(m => m.Name.ToLower().Contains(searchTermLowerCase));
        }
    }
}
