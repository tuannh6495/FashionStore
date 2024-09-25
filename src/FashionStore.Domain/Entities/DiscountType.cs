using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class DiscountType : BaseEntity
	{
		public string Name { get; set; }

		public ICollection<Discount>? Discounts { get; set; }

		public DiscountType(string name) 
		{
			Name = name;
		}
	}
}
