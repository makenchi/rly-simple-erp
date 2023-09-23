﻿using System.ComponentModel.DataAnnotations;

namespace ErpStorageApi.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
