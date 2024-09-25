using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class UserPromotion : BaseEntity
	{
		public int UserId { get; set; }
		public User? User { get; set; }

		public int PromotionId { get; set; }
		public Promotion? Promotion { get; set; }
	}
}
