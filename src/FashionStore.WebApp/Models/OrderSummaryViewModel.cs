namespace FashionStore.WebApp.Models
{
    public class OrderSummaryViewModel
    {
        public decimal Subtotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal Total { get; set; }
    }
}
