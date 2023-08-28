using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Net;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Catalog.Repositories;
using Catalog.Entities;
using Catalog.Dtos;
using System.Linq;

namespace Catalog.Controllers{
    [ApiController]
    [Route("items")]
    public class ItemsController: ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository ){
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems(){
            return repository.GetItems().Select( item => item.AsDto());
        }

        // GET /items/{id}
        [HttpGet("{id}")]
        public ItemDto GetItem(Guid id){
            return repository.GetItem(id).AsDto();
        }  

        [HttpPost]
        public ActionResult<ItemDto> CreateItem (CreateItemDto itemDto){
            Item item = new(){
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CratedDate = DateTimeOffset.UtcNow
            };

            repository.CreateItem(item);

            return 
        }
    }
}