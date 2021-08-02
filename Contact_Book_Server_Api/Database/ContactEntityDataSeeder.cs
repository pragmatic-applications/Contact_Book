using System.Collections.Generic;

using Domain;

using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class ContactEntityDataSeeder
    {
        private static int idCount = 0;

        private static readonly List<ContactEntity> items = new()
        {
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Jane Doe",
                FirstName = "Jane",
                LastName = "Doe",
                Email = "jane@doe.com",
                Phone = "01111111111",
                Address = "5 Grand Lodge, London UK",
                //Image = "Default.png",
                //IsChecked = false,
                //CreatedDate = DateTimeOffset.UtcNow,
                ContactEntityCategoryId = (int)ContactCategoryType.Family
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Tom Browne",
                FirstName = "Tom",
                LastName = "Browne",
                Email = "tom@browne.com",
                Phone = "02111111111",
                Address = "14 The Glades, New York US",
                //Image = "Default.png",
                //IsChecked = false,
                //CreatedDate = DateTimeOffset.UtcNow,
                ContactEntityCategoryId = (int)ContactCategoryType.Friend
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Lucy Smith",
                FirstName = "Lucy",
                LastName = "Smith",
                Email = "lucy@smith.com",
                Phone = "03111111111",
                Address = "5 Hoble House, Penge, London UK",
                //Image = "Default.png",
                //IsChecked = false,
                //CreatedDate = DateTimeOffset.UtcNow,
                ContactEntityCategoryId = (int)ContactCategoryType.Work
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Halie Jones",
                FirstName = "Halie",
                LastName = "Jones",
                Email = "halie@jones.com",
                Phone = "04111111111",
                Address = "11 Broad Lane, Paris France",
                //Image = "Default.png",
                //IsChecked = false,
                //CreatedDate = DateTimeOffset.UtcNow,
                ContactEntityCategoryId = (int)ContactCategoryType.Business
            },
        };

        public static void CreateContactEntities(this ModelBuilder modelBuilder) => modelBuilder.Entity<ContactEntity>().HasData(items);
    }
}
