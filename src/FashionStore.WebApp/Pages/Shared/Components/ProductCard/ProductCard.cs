using Microsoft.AspNetCore.Mvc;
using FashionStore.Domain.Entities;
using FashionStore.Application.DTOs;

namespace ProductVC
{
    public class ProductCard : ViewComponent
    {
        public IViewComponentResult Invoke(ProductDTO product)
        {
            return View(product);
        }
    }
}
