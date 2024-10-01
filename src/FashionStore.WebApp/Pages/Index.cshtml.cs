using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FashionStore.WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IProductService _productService;
    private readonly IReviewService _reviewService;

    public bool IsDatePostShowed { get; set; }

    public IEnumerable<ProductDTO> NewArrivals { get; set; }
    public IEnumerable<ProductDTO> TopSelling { get; set; }
    public IEnumerable<ReviewDTO> OurHappyCustomers { get; set; }


    public IndexModel(ILogger<IndexModel> logger, IProductService productService, IReviewService reviewService)
    {
        _logger = logger;
        _productService = productService;
        _reviewService = reviewService;
        
    }
    public async Task OnGetAsync()
    {
        NewArrivals = await _productService.GetNewArrivalProductsAsync();

        TopSelling = await _productService.GetTopSellingProductsAsync();

        OurHappyCustomers = await _reviewService.GetOurHappyCustomerReviewAsync();
    }
}
