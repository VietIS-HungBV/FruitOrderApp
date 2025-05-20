using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FruitOder.Shared.Dtos
{
    public partial class ProductDto : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ObservableProperty]
        public string? _image;

        public decimal Price { get; set; }
        public string Unit { get; set; }
        public short CategoryId { get; set; }

        [ObservableProperty]
        public int _cartQuantitty;

        public ProductDto(int id, string name, string? image, decimal price, string unit, short categoryId)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
            Unit = unit;
            CategoryId = categoryId;
        }
    }
}
