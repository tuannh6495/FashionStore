using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class DressStyleP : BaseEntity
	{
		public int DressStyleId { get; set; }
		public DressStyle? DressStyle { get; set; }

		public int ProductId { get; set; }
		public Product? Product { get; set; }
	}
}
