using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Discount : BaseEntity
	{
		public double DiscountValue { get; set; }

		public int DiscountTypeId { get; set; }
		public DiscountType? DiscountType { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}
