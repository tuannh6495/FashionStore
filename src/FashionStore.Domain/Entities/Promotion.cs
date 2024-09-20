using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class Promotion : BaseEntity
	{
		public string Name { get; set; }

		public int CartId { get; set; }
		public Cart Cart { get; set; }

		public ICollection<UserPromotion> UserPromotions { get; set; }
	}
}
