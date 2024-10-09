using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class CartP : BaseEntity
	{
		public int CartId { get; set; }
		public Cart Cart { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int Quantity { get; set; }
        public double TotalPrice => Product.Price * Quantity;
    }
}
