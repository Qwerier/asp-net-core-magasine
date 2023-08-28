using System;
namespace Catalog.Dtos{
    public record CreateItemDto{
        public string Name {get; set;}
        public int Price { get; set; }
    }
}