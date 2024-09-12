using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductVC;
using ReviewVC;

namespace FashionStore.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Product> NewArrivals;
    public List<Product> TopSelling;
    public List<Review> OurHappyCustomers;
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

        OurHappyCustomers = new List<Review>
        {
            new Review { ReviewRating = 5, NameCustomer = "Saradh M.", Comment = "I'm blown away by the quality and style of the clothes I received from Shop.co. From casual wear to elegant dresses, every piece I've bought has exceeded my expectations." },
            new Review { ReviewRating = 5, NameCustomer = "Alex K.", Comment = "Finding clothes that align with my personal style used to be a challenge until I discovered Shop.co. The range of options they offer is truly remarkable, catering to a variety of tastes and occasions." },
            new Review { ReviewRating = 5, NameCustomer = "James L.", Comment = "As someone who's always on the lookout for unique fashion pieces, I'm thrilled to have stumbled upon Shop.co. The selection of clothes is not only diverse but also on-point with the latest trends." },
            new Review { ReviewRating = 5, NameCustomer = "Moona T.", Comment = "I was pleasantly surprised by the quality of the clothes I received from Shop.co. The fit is perfect, and the styles are so trendy! I can't wait to shop here again for my next wardrobe update." },
            new Review { ReviewRating = 5, NameCustomer = "Emily R.", Comment = "Shop.co has become my go-to for fashion! The variety is amazing, and I've found pieces that are both stylish and comfortable. Every time I wear something from here, I get compliments!" },
            new Review { ReviewRating = 5, NameCustomer = "Michael T.", Comment = "I love how easy it is to find outfits that suit my style at Shop.co. Their collection is fresh and unique, and I appreciate the attention to detail in every piece. Highly recommend to everyone!" }
        };
    }
}
