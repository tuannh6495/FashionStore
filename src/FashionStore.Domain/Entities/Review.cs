namespace FashionStore.Domain.Entities
{
	public class Review : BaseEntity
	{
		public int ProductId { get; set; }
		public Product? Product { get; set; } 
		
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }

        public decimal ReviewRating { get; set; }
        public string ?Comment { get; set; }
        public DateTime DatePost { get; set; }
        //public string FullNameCustomer
        //{
        //    get
        //    {
        //        if (AppUser != null)
        //        {
        //            return $"{AppUser.LastName} {AppUser.FirstName}";
        //        }
        //        return string.Empty;  
        //    }
        //}
    }
}
