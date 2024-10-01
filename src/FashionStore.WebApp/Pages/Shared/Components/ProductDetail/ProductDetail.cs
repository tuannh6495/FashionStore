using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FashionStore.WebApp.ViewComponents
{
    public class ProductDetailViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ProductDetailViewModel model)
        {
            return View(model);
        }
    }

    public class ProductDetailViewModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Rating { get; set; }
        public decimal PriceDiscount { get; set; }
        public decimal PriceOriginal { get; set; }
        public string? Description { get; set; }
        public List<string>? Colors { get; set; }
        public List<string>? Sizes { get; set; }
        public List<string>? Photos { get; set; }
    }
}
