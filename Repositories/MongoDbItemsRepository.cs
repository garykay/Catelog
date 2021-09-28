using System;
using System.Collections.Generic;
using Category.Entities;
using MongoDB.Driver;

namespace Catelog.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {

        public MongoDbItemsRepository(IMongoClient mongoClient) {

        }
        
        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}