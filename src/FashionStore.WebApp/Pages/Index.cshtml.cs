using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FashionStore.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IProductService _productService;

    public bool IsDatePostShowed { get; set; }

    public IEnumerable<ProductDTO> NewArrivals { get; set; }
    public IEnumerable<ProductDTO> TopSelling { get; set; }
    public List<Review> OurHappyCustomers;

    public IndexModel(ILogger<IndexModel> logger, IProductService productService)
    {
        _productService = productService;
        _logger = logger;
    }
    public async Task OnGetAsync()
    {
        NewArrivals = await _productService.GetNewArrivalProductsAsync();

        TopSelling = await _productService.GetTopSellingProductsAsync();


        OurHappyCustomers = new List<Review>
        {
            new Review { ReviewRating = 5, Comment = "I'm blown away by the quality and style of the clothes I received from Shop.co. From casual wear to elegant dresses, every piece I've bought has exceeded my expectations." },
            new Review { ReviewRating = 5, Comment = "Finding clothes that align with my personal style used to be a challenge until I discovered Shop.co. The range of options they offer is truly remarkable, catering to a variety of tastes and occasions." },
            new Review { ReviewRating = 5, Comment = "As someone who's always on the lookout for unique fashion pieces, I'm thrilled to have stumbled upon Shop.co. The selection of clothes is not only diverse but also on-point with the latest trends." },
            new Review { ReviewRating = 5, Comment = "I was pleasantly surprised by the quality of the clothes I received from Shop.co. The fit is perfect, and the styles are so trendy! I can't wait to shop here again for my next wardrobe update." },
            new Review { ReviewRating = 5, Comment = "Shop.co has become my go-to for fashion! The variety is amazing, and I've found pieces that are both stylish and comfortable. Every time I wear something from here, I get compliments!" },
            new Review { ReviewRating = 5, Comment = "I love how easy it is to find outfits that suit my style at Shop.co. Their collection is fresh and unique, and I appreciate the attention to detail in every piece. Highly recommend to everyone!" }
        };
    }
}
