using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public List<string> ImageUrls { get; set; }
        public string Name { get; set; }
        public string Unit { get; } = "$";
        public double Price { get; set; }
        public int ?DiscountId { get; set; }
        public double DiscountValue { get; set; }
        public double DiscountedPrice {
			get
			{
				return Price - (Price * (DiscountValue) / 100);
			}
		}
        public decimal AvgRating { get; set; }
    }
}
