using Constants;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class IdentityRolesSeedData
    {
        private static IEnumerable<IdentityRole> GetIdentityRoles()
        {
            var id = 0;

            return new IdentityRole[]
            {
                new IdentityRole
                {
                  Id = (++id).ToString(),
                  Name = IdentityRoleName.ADMIN,
                  NormalizedName = IdentityRoleName.ADMIN_NORMALIZED
                },
                new IdentityRole
                {
                  Id = (++id).ToString(),
                  Name = IdentityRoleName.SUPER_ADMIN,
                  NormalizedName = IdentityRoleName.SUPER_ADMIN_NORMALIZED
                },
                new IdentityRole
                {
                  Id = (++id).ToString(),
                  Name = IdentityRoleName.EDITOR,
                  NormalizedName = IdentityRoleName.EDITOR_NORMALIZED
                },
                new IdentityRole
                {
                  Id = (++id).ToString(),
                  Name = IdentityRoleName.REGULAR_USER,
                  NormalizedName = IdentityRoleName.REGULAR_USER_NORMALIZED
                }
            };
        }

        public static void CreateIdentityRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData
            (
              GetIdentityRoles()
            );
        }
    }
}
