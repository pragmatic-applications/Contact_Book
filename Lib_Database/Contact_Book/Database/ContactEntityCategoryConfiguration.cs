
using System;
using System.Collections.Generic;

using Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database
{
    public class ContactEntityCategoryConfiguration : IEntityTypeConfiguration<ContactEntityCategory>
    {
        public void Configure(EntityTypeBuilder<ContactEntityCategory> builder)
        {
            builder.HasKey(item => item.Id);
            builder.Property(item => item.Name).IsRequired();

            builder.HasData(items);
        }

        private static int idCount = 0;

        private static List<ContactEntityCategory> items
        {
            get => new()
            {
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Unspecified)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Owner)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Family)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Friend)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Home)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Work)
                },
                new ContactEntityCategory
                {
                    Id = ++idCount,
                    Name = Enum.GetName(ContactCategoryType.Business)
                }
            };
        }
    }
}
