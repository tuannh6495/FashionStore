namespace FashionStore.Domain.Entities
{
	public class Review : BaseEntity
	{
		public int ProductId { get; set; }
		public Product? Product { get; set; } 
		
		public int UserId { get; set; }
		public User? User { get; set; }

        public decimal ReviewRating { get; set; }
        public string ?Comment { get; set; }
        public DateTime DatePost { get; set; }
    }
}
