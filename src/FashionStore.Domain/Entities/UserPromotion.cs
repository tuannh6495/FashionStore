using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Entities
{
	public class UserPromotion : BaseEntity
	{
		public string AppUserId { get; set; }
		public AppUser? AppUser { get; set; }

		public int PromotionId { get; set; }
		public Promotion? Promotion { get; set; }
	}
}
