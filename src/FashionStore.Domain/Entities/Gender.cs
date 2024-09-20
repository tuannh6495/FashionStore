using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Gender : BaseEntity
	{
		public string Name { get; set; }

		public ICollection<Product> Products { get; set; }
	}
}
