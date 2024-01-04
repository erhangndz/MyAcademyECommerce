﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MyAcademyECommerce.Services.Catalog.Models;

namespace MyAcademyECommerce.Services.Catalog.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
 
        public string CategoryId { get; set; }
 
        public Category Category { get; set; }
    }
}
