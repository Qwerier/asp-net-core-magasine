using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos{
    public record CreateItemDto{
        [Required]
        public string Name { get; set;}

        [Required]
        public int Price { get; set; }

    }
}