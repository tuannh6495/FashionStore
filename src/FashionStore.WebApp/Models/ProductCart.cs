namespace FashionStore.WebApp.Models
{
	public class ProductCart
	{
		public string? Name { get; set; }
		public string? Size { get; set; }
		public string? Color { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string? ImagePath { get; set; }
	}
}
