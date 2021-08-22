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
            //--------------------------------------------------------------
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
                ContactEntityCategoryId = (int)ContactCategoryType.Home
            },
            //--------------------------------------------------------------
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "A List Ltd.",
                FirstName = "Steve",
                LastName = "Marriott",
                Email = "Steve@AListLtd.com",
                Phone = "05111144111",
                Address = "A List Ltd Address, NY USA",
                ContactEntityCategoryId = (int)ContactCategoryType.Business
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "MicroTech",
                FirstName = "Antonio",
                LastName = "Bolt",
                Email = "Antonio@MicroTech.com",
                Phone = "06111111111",
                Address = "Antonio's Address, Siville Spain",
                ContactEntityCategoryId = (int)ContactCategoryType.Business
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "McKenzie Porter",
                FirstName = "McKenzie",
                LastName = "Porter",
                Email = "McKenzie@Email.com",
                Phone = "07111112211",
                Address = "McKenzie Address, Clidesdale Scotland",
                ContactEntityCategoryId = (int)ContactCategoryType.Unspecified
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Barry Holland",
                FirstName = "Barry",
                LastName = "Holland",
                Email = "Barry@Email.com",
                Phone = "08111111111",
                Address = "Barry's Address, St. Kitts",
                ContactEntityCategoryId = (int)ContactCategoryType.Unspecified
            },
            //--------------------------------------------------------------
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Millie Higgins",
                FirstName = "Millie",
                LastName = "Jones",
                Email = "Millie@Email.com",
                Phone = "09111111111",
                Address = "Millie's Address, Gre Ireland",
                ContactEntityCategoryId = (int)ContactCategoryType.Unspecified
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "The Artz",
                FirstName = "Emma",
                LastName = "Pradas",
                Email = "Emma@TheArtz.com",
                Phone = "01011191111",
                Address = "The Artz Address, Canada",
                ContactEntityCategoryId = (int)ContactCategoryType.Business
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Clive Hilton",
                FirstName = "Clive",
                LastName = "Hilton",
                Email = "Clive@Email.com",
                Phone = "04111111112",
                Address = "Clive's Address, Ilford UK",
                ContactEntityCategoryId = (int)ContactCategoryType.Friend
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Sharon Clark",
                FirstName = "Sharon",
                LastName = "Jones",
                Email = "Sharon@Email.com",
                Phone = "04171111113",
                Address = "Sharon's Address, Barbados",
                ContactEntityCategoryId = (int)ContactCategoryType.Unspecified
            },
            //--------------------------------------------------------------
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Tony Blaze",
                FirstName = "Tony",
                LastName = "Blaze",
                Email = "Tony@Email.com",
                Phone = "09111111111",
                Address = "Tony's Address, London",
                ContactEntityCategoryId = (int)ContactCategoryType.Work
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Junie Pascal",
                FirstName = "Junie",
                LastName = "Jones",
                Email = "Junie@Email.com",
                Phone = "01011331111",
                Address = "Junie's Address, USA",
                ContactEntityCategoryId = (int)ContactCategoryType.Friend
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Mark Landis",
                FirstName = "Mark",
                LastName = "Jones",
                Email = "Mark@Email.com",
                Phone = "04111117512",
                Address = "Mark's Address, Canada",
                ContactEntityCategoryId = (int)ContactCategoryType.Work
            },
            new ContactEntity
            {
                Id = ++idCount,
                ContactName = "Mygonne McNally",
                FirstName = "Mygonne",
                LastName = "McNally",
                Email = "Mygonne@Email.com",
                Phone = "04119111713",
                Address = "Mygonne's Address, Jamaica",
                ContactEntityCategoryId = (int)ContactCategoryType.Unspecified
            }
            //--------------------------------------------------------------
        };
    }
}
