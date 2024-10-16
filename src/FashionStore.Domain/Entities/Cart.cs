namespace FashionStore.Domain.Entities
{
    public class Cart : BaseEntity
	{
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }

		public ICollection<CartP>? CartPs { get; set; }

        public Cart(string appUserId)
        {
            AppUserId = appUserId ?? throw new ArgumentNullException(nameof(appUserId));
        }
    }
}

