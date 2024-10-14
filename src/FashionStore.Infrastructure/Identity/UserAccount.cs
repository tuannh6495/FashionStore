using Microsoft.AspNetCore.Identity;

namespace FashionStore.Infrastructure.Identity
{
	public class UserAccount : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		// Thêm các thuộc tính khác nếu cần
	}
}
