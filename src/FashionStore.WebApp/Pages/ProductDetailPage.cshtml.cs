using FashionStore.WebApp.ViewComponents;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FashionStore.Application.Interfaces;
using FashionStore.Application.DTOs;

namespace FashionStore.WebApp.Pages
{
    public class ProductDetailPageModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;

        public bool IsDatePostShowed { get; set; }
        public int ReviewCount { get; set; }

        public ProductDetailDTO ProductDetail { get; set; }
        public IEnumerable<ReviewDTO> AllReviews { get; set; }
        public IEnumerable<ProductDTO> RelatedProducts { get; set; }

        
        //public List<Product> RelatedProducts { get; set; }

        public ProductDetailPageModel(IProductService productService, IReviewService reviewService)
        {
            _productService = productService;
            _reviewService = reviewService;
        }

        public async Task OnGetAsync()
        {
            if (int.TryParse(Request.Query["id"], out int id))
            {
                ProductDetail = await _productService.GetProductDetailAsync(id);
                AllReviews = await _reviewService.GetProductReviewsAsync(id);
                ReviewCount = AllReviews?.Count() ?? 0;
                RelatedProducts = await _productService.GetRelatedProductsAsync(id);
            }
            else
            {
                RedirectToPage("/Error");
            }
        }
    }
}
