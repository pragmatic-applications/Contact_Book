
using System;
using System.Collections.Generic;

using Domain;

using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class ContactEntityCategoryDataSeeder
    {
        private static int idCount = 0;

        public static List<ContactEntityCategory> Categories
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

        public static void CreateContactEntityCategories(this ModelBuilder modelBuilder) => modelBuilder.Entity<ContactEntityCategory>().HasData(Categories);
    }
}
