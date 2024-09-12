using Microsoft.AspNetCore.Mvc;

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
