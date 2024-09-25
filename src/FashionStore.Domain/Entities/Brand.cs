using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Brand : BaseEntity
	{
		public string Name { get; set; } 

		public ICollection<Product>? Products { get; set; }
		public ICollection<DiscountBrand>? DiscountBrands { get; set; }

		public Brand(string name) 
		{
			Name = name;
		}
	}
}
