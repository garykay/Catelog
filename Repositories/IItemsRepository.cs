using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Category.Entities;

namespace Catelog.Repositories{

    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();

        Task CreateItemAsync(Item item);

        Task UpdateItemAsync(Item item);

        Task DeleteItemAsync(Guid id);

    }
    
}