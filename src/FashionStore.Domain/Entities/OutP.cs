using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class OutP : BaseEntity
	{
		public int OutstandingId { get; set; }
		public Outstanding Outstanding { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
