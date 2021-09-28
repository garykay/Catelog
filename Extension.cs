using Catalog.Dtos;
using Category.Entities;

namespace Catelog
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {

            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };

        }

    }
}