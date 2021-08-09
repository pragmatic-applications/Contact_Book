using System.Collections.Generic;

using Domain;

using DTOs;

namespace Extensions
{
    public static class ContactEntityMapper
    {
        public static ContactEntity Map(this ContactEntityDtoUpdate item, ContactEntity newItem)
        {
            newItem.ContactName = item.ContactName;
            newItem.FirstName = item.FirstName;
            newItem.LastName = item.LastName;
            newItem.Email = item.Email;
            newItem.Phone = item.Phone;
            newItem.Address = item.Address;
            newItem.Image = item.Image;
            newItem.IsChecked = item.IsChecked.Value;
            newItem.ContactEntityCategoryId = item.ContactEntityCategoryId.Value;

            return newItem;
        }

        public static ContactEntity Map(this ContactEntityDtoCreate item)
        {
            return new ContactEntity
            {
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                ContactEntityCategoryId = item.ContactEntityCategoryId
            };
        }

        public static ContactEntityDto MapDefault(this ContactEntity item)
        {
            return new ContactEntityDto
            {
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                ContactEntityCategoryId = item.ContactEntityCategoryId
            };
        }
        public static ContactEntityDto Map(this ContactEntity item)
        {
            var contactEntityCategory = new ContactEntityCategory
            {
                Id = item.ContactEntityCategoryId,
                Name = item.ContactEntityCategory.Name
            };

            return new ContactEntityDto
            {
                Id = item.Id,
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                CreatedDate = item.CreatedDate,
                ContactEntityCategoryId = item.ContactEntityCategoryId,
                ContactEntityCategory = contactEntityCategory,
                ContactCategory = item.ContactEntityCategory.Name
            };
        }
        public static ContactEntity Map(this ContactEntityDto item)
        {
            return new ContactEntity
            {
                Id = item.Id,
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                CreatedDate = item.CreatedDate,
                ContactEntityCategoryId = item.ContactEntityCategoryId,
                ContactEntityCategory = item.ContactEntityCategory
            };
        }

        public static IEnumerable<ContactEntityDto> MapList(this IEnumerable<ContactEntity> models)
        {
            List<ContactEntityDto> newItems = new();

            foreach(var item in models)
            {
                var newItem = new ContactEntityDto
                {
                    Id = item.Id,
                    ContactName = item.ContactName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Phone = item.Phone,
                    Address = item.Address,
                    Image = item.Image,
                    IsChecked = item.IsChecked,
                    CreatedDate = item.CreatedDate,
                    ContactEntityCategoryId = item.ContactEntityCategoryId,
                    ContactEntityCategory = item.ContactEntityCategory
                };

                newItems.Add(newItem);
            }

            return newItems;
        }
        public static List<ContactEntity> MapList(this List<ContactEntityDto> models)
        {
            List<ContactEntity> newItems = new();

            foreach(var item in models)
            {
                var newItem = new ContactEntity
                {
                    Id = item.Id,
                    ContactName = item.ContactName,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Phone = item.Phone,
                    Address = item.Address,
                    Image = item.Image,
                    IsChecked = item.IsChecked,
                    CreatedDate = item.CreatedDate,
                    ContactEntityCategoryId = item.ContactEntityCategoryId,
                    ContactEntityCategory = item.ContactEntityCategory
                };

                newItems.Add(newItem);
            }

            return newItems;
        }

        public static ContactEntityDto ToContactEntityDto(this ContactEntity item)
        {
            return new ContactEntityDto
            {
                Id = item.Id,
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                CreatedDate = item.CreatedDate,
                ContactEntityCategoryId = item.ContactEntityCategoryId,
                ContactEntityCategory = item.ContactEntityCategory
            };
        }
        public static ContactEntity ToContactEntity(this ContactEntityDto item)
        {
            return new ContactEntity
            {
                Id = item.Id,
                ContactName = item.ContactName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                Phone = item.Phone,
                Address = item.Address,
                Image = item.Image,
                IsChecked = item.IsChecked,
                CreatedDate = item.CreatedDate,
                ContactEntityCategoryId = item.ContactEntityCategoryId,
                ContactEntityCategory = item.ContactEntityCategory
            };
        }
    }
}
