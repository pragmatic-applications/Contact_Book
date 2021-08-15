using System.Collections.Generic;

using Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database
{
    public class ContactEntityConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder.HasKey(item => item.Id);
            //builder.Property(item => item.ContactName).HasAnnotation("Name", "Contact Name").IsRequired();
            builder.Property(item => item.ContactName).IsRequired();
            builder.Property(item => item.Email).IsRequired();

            builder.HasData(items);
        }

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
                ContactEntityCategoryId = (int)ContactCategoryType.Business
            }
        };
    }
}
