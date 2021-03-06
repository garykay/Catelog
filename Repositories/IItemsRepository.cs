using System;
using System.Collections.Generic;
using Category.Entities;

namespace Catelog.Repositories{

    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void CreateItem(Item item);

        void UpdateItem(Item item);

        void DeleteItem(Guid id);

    }
    
}