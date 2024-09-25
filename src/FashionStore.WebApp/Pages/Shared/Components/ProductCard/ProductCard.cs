using Microsoft.AspNetCore.Mvc;
using FashionStore.Domain.Entities;

namespace ProductVC
{
    public class ProductCard : ViewComponent
    {
        public IViewComponentResult Invoke(Product product)
        {
            return View(product);
        }
    }
}
