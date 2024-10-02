using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public List<string> ImageUrls { get; set; }
        public string Name { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }
        public string? Description { get; set; }
        public decimal AvgRating { get; set; }
        public List<string> ColorHexCodes { get; set; }
        public List<string> SizeNames { get; set; }
    }
}
