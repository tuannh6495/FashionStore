using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Cart : BaseEntity
	{
		public int UserId { get; set; }
		public User? User { get; set; }

		public ICollection<CartP>? CartPs { get; set; }
    }
}
