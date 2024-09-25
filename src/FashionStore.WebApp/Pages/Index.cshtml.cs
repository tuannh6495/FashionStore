using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            new Product ( new List<string> { "/Images/TWTD.png", "/Images/TWTD.png", "/Images/TWTD.png" }, "T-shirt with Tape Details" ) { AvgRating = 4.5m, Price = 120  },
            new Product ( new List<string> { "/Images/SFJ.png", "/Images/SFJ.png", "/Images/SFJ.png" }, "Skinny Fit Jeans" ) { AvgRating = 3.5m, Price = 240 },
            new Product ( new List<string> { "/Images/CS.png", "/Images/CS.png", "/Images/CS.png" }, "Checkered Shirt" ) { AvgRating = 4.5m, Price = 180 },
            new Product ( new List<string> { "/Images/SST.png", "/Images/SST.png", "/Images/SST.png" }, "Sleeve Striped T-shirt" ) { AvgRating = 4.5m, Price = 130 }
        };

        TopSelling = new List<Product>
        {
            new Product ( new List<string> { "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png" }, "Vertical Striped Shirt" ) { AvgRating = 5m, Price = 212 },
            new Product ( new List<string> { "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png" }, "Courage Graphic T-shirt" ) { AvgRating = 4m, Price = 145 },
            new Product ( new List<string> { "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png" }, "Loose Fit Bermuda Shorts" ) { AvgRating = 3m, Price = 80 },
            new Product ( new List<string> { "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png", "/Images/FadedSkinnyJeans.png" }, "Faded Skinny Jeans" ) { AvgRating = 4.5m, Price = 210 }
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
