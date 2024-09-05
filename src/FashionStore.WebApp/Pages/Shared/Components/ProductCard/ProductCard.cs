using Microsoft.AspNetCore.Mvc;

namespace XTLAB
{
    public class ProductCard : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = new List<Product>() {
                new Product() { ImageUrl = "/Images/T-shirtWithTapeDetails.png", Name = "T-shirt with Tape Details", Rating =4.5, Price = "$120"},
                new Product() { ImageUrl = "/Images/SkinnyFitJeans.png", Name = "Skinny Fit Jeans", Rating =3.5, Price = "$240"},
                new Product() { ImageUrl = "/Images/CheckeredShirt.png", Name = "Checkered Shirt", Rating =4.5, Price = "$180"},
                new Product() { ImageUrl = "/Images/SleeveStripedT-shirt.png", Name = "Sleeve Striped T-shirt", Rating =4.5, Price = "$130"}
            };
            return View<List<Product>>(products); 
        }
    }
}
