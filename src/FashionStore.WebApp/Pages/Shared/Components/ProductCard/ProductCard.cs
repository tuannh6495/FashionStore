using Microsoft.AspNetCore.Mvc;

namespace XTLAB
{
    public class ProductCard : ViewComponent
    {
        public IViewComponentResult Invoke(Product product)
        {
            return View(product);
        }
    }
}
