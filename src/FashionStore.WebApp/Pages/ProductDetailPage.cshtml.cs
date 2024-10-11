using FashionStore.WebApp.ViewComponents;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FashionStore.Application.Interfaces;
using FashionStore.Application.DTOs;
using FashionStore.WebApp.Common;

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

        public string ForeImage { get; set; }
        public string BackImage { get; set; }
        public string ModelImage { get; set; }

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

                ForeImage = ProductDetail.GetImageByType("fore");
                BackImage = ProductDetail.GetImageByType("back");
                ModelImage = ProductDetail.GetImageByType("model");
            }
            else
            {
                RedirectToPage("/Error");
            }
        }

        public IActionResult OnPostAddToCart(int productId, string colorName, string sizeName, int quantity)
        {
            var product = _productService.GetProductByIdAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetObjectFromJson<List<CartPDTO>>("Cart") ?? new List<CartPDTO>();
            var cartItem = cart.FirstOrDefault(c => c.ProductId == productId && c.SizeName == sizeName && c.ColorName == colorName);
            if (cartItem != null)
            {
                cartItem.Quantity += quantity;
            }
            else
            {
                var foreImage = ProductDetail.GetImageByType("fore");
                cart.Add(new CartPDTO
                {
                    ProductId = productId,
                    ProductName = product.Result.Name, 
                    Quantity = quantity,
                    SizeName = sizeName,
                    ColorName = colorName,
                    Price = product.Result.Price,
                    TotalPrice = product.Result.Price * quantity,
                    ImageUrls = new List<string> { foreImage }
                });
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);

            return RedirectToPage("Cart");
        }

    }
}
