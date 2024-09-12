using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XTLAB;

namespace FashionStore.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Product> NewArrivals;
    public List<Product> TopSelling;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
        NewArrivals = new List<Product>
        {
            new Product { ImageUrl = "/Images/TWTD.png", Name = "T-shirt with Tape Details", Rating = 4.5, Unit = "$", Price = 120 },
            new Product { ImageUrl = "/Images/SFJ.png", Name = "Skinny Fit Jeans", Rating = 3.5, Unit = "$", Price = 240 },
            new Product { ImageUrl = "/Images/CS.png", Name = "Checkered Shirt", Rating = 4.5, Unit = "$", Price = 180 },
            new Product { ImageUrl = "/Images/SST.png", Name = "Sleeve Striped T-shirt", Rating = 4.5, Unit = "$", Price = 130 }
        };

        TopSelling = new List<Product>
        {
            new Product { ImageUrl = "/Images/VerticalStripedShirt.png", Name = "Vertical Striped Shirt", Rating = 5, Unit = "$", Price = 212 },
            new Product { ImageUrl = "/Images/CourageGraphicT-shirt.png", Name = "Courage Graphic T-shirt", Rating = 4.0, Unit = "$", Price = 145 },
            new Product { ImageUrl = "/Images/LooseFitBermudaShorts.png", Name = "Loose Fit Bermuda Shorts", Rating = 3.0, Unit = "$", Price = 80 },
            new Product { ImageUrl = "/Images/FadedSkinnyJeans.png", Name = "Faded Skinny Jeans", Rating = 4.5, Unit = "$", Price = 210 }
        };
    }
}
