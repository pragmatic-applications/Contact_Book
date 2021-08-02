using System.Collections.Generic;

using Domain;

using DTOs;

namespace Extensions
{
    public static class ContactEntityCategoryMapper
    {
        public static ContactEntityCategory Map(this ContactEntityCategoryDtoUpdate item, ContactEntityCategory newItem)
        {
            newItem.Name = item.Name;

            return newItem;
        }
        public static ContactEntityCategory Map(this ContactEntityCategoryDtoCreate item)
        {
            return new ContactEntityCategory
            {
                Name = item.Name
            };
        }

        public static ContactEntityCategoryDto Map(this ContactEntityCategory item)
        {
            return new ContactEntityCategoryDto
            {
                Id = item.Id,
                Name = item.Name
            };
        }
        public static ContactEntityCategory Map(this ContactEntityCategoryDto item)
        {
            return new ContactEntityCategory
            {
                Id = item.Id,
                Name = item.Name
            };
        }

        public static IEnumerable<ContactEntityCategoryDto> MapList(this IEnumerable<ContactEntityCategory> models)
        {
            List<ContactEntityCategoryDto> newItems = new();

            foreach(var item in models)
            {
                var newItem = new ContactEntityCategoryDto
                {
                    Id = item.Id,
                    Name = item.Name
                };

                newItems.Add(newItem);
            }

            return newItems;
        }
        public static List<ContactEntityCategory> MapList(this List<ContactEntityCategoryDto> models)
        {
            List<ContactEntityCategory> newItems = new();

            foreach(var item in models)
            {
                var newItem = new ContactEntityCategory
                {
                    Id = item.Id,
                    Name = item.Name
                };

                newItems.Add(newItem);
            }

            return newItems;
        }

        public static ContactEntityCategoryDto ToContactEntityCategoryDto(this ContactEntityCategory item)
        {
            return new ContactEntityCategoryDto
            {
                Id = item.Id,
                Name = item.Name
            };
        }
        public static ContactEntityCategory ToContactEntityCategory(this ContactEntityCategoryDto item)
        {
            return new ContactEntityCategory
            {
                Id = item.Id,
                Name = item.Name
            };
        }
    }
}
