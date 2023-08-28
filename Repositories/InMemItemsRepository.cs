using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;
using System;

namespace Catalog.Repositories{

    public class InMemItemsRepository : IItemsRepository{
        private readonly List<Item> items = new List<Item>{
            new Item{Id=Guid.NewGuid(), Name = "Potion", Price= 6, CreatedDate=DateTimeOffset.UtcNow},
            new Item{Id=Guid.NewGuid(), Name = "Iron Sword", Price= 40, CreatedDate=DateTimeOffset.UtcNow},
            new Item{Id=Guid.NewGuid(), Name = "Bronze Shield", Price= 32, CreatedDate=DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems(){
            return items;
        }

        public Item GetItem(Guid id){
            return items.Where(item => item.Id == id).FirstOrDefault();
        }

        public void CreateItem(Item item){
            items.Add(item);
        }
        
    }
}