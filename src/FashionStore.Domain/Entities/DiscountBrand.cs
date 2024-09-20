using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class DiscountBrand : BaseEntity
	{
		public int DiscountId { get; set; }
		public Discount Discount { get; set; }

		public int BrandId { get; set; }
		public Brand Brand { get; set; }
	}
}
