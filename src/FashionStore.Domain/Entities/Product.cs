using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
		public decimal AvgRating { get; set; } 

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public int GenderId { get; set; }
		public Gender Gender { get; set; }

		public int BrandId { get; set; }
		public Brand Brand { get; set; }

		public ICollection<OutP> OutPs { get; set; }
		public ICollection<SizeP> SizePs { get; set; }
		public ICollection<ColorP> ColorPs { get; set; }
		public ICollection<CartP> CartPs { get; set; }
		public ICollection<Review> Reviews { get; set; }
		public ICollection<DressStyleP> DressStylePs { get; set; }
		public ICollection<DiscountProduct> DiscountProducts { get; set; }
	}
}
