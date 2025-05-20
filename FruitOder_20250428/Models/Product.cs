﻿namespace FruitOder_20250428.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int CartQuantity { get; set; }
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
