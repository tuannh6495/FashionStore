using Microsoft.AspNetCore.Mvc;
using FashionStore.WebApp.Models;  // Thêm dòng này để tham chiếu đến ViewModel

namespace FashionStore.WebApp.Components.OrderSummary
{
    public class OrderSummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(decimal subtotal, decimal discountAmount, decimal deliveryFee, decimal total)
        {
            var model = new OrderSummaryViewModel
            {
                Subtotal = subtotal,
                DiscountAmount = discountAmount,
                DeliveryFee = deliveryFee,
                Total = total
            };

            return View(model);
        }
    }
}
