using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;

namespace Database
{
    public class DevUserEntityConfiguration : IEntityTypeConfiguration<DevUser>
    {
        public void Configure(EntityTypeBuilder<DevUser> builder)
        {
            builder.HasData(items);
        }

        private static int id = 0;
        private static readonly List<DevUser> items = new()
        {
            new DevUser
            (
               ++id, "curious-coder@outlook.com"
            )
        };
    }
}
