using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class ProductDTO
    {
        public List<string> ImageUrls { get; set; }
        public string Name { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }
        public decimal AvgRating { get; set; }
    }
}
