using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;

namespace Database
{
    public class AppModelEntityConfiguration : IEntityTypeConfiguration<AppModel>
    {
        public void Configure(EntityTypeBuilder<AppModel> builder)
        {
            builder.HasData(items);
        }

        private static int id = 0;
        private static readonly List<AppModel> items = new()
        {
            new AppModel
            (
                ++id,
                "===============",
                "===============",
                "===============", "==============="
            )
        };
    }
}
