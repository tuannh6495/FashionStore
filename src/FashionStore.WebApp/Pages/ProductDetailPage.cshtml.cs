using FashionStore.WebApp.ViewComponents;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductVC;
using ReviewVC;
using System.Security.Cryptography.X509Certificates;

namespace FashionStore.WebApp.Pages
{
    public class ProductDetailPageModel : PageModel
    {
        
        public List<Review> AllReviews { get; set; }
        public List<Product> RelatedProducts { get; set; }
		public ProductDetailViewModel ProductDetail { get; set; }


        public void OnGet()
        {
            AllReviews = new List<Review>
            {
            new Review { ReviewRating = 4.5, NameCustomer = "Samantha D.", Comment = "I absolutely love this t-shirt! The design is unique and the fabric feels so comfortable. As a fellow designer, I appreciate the attention to detail. It's become my favorite go-to shirt.", DatePost = new DateTime (2023, 8, 14) },
            new Review { ReviewRating = 4, NameCustomer = "Alex M.", Comment = "The t-shirt exceeded my expectations! The colors are vibrant and the print quality is top-notch. Being a UI/UX designer myself, I'm quite picky about aesthetics, and this t-shirt definitely gets a thumbs up from me.", DatePost = new DateTime (2023, 8, 15) },
            new Review { ReviewRating = 4.5, NameCustomer = "Ethan R.", Comment = "This t-shirt is a must-have for anyone who appreciates good design. The minimalistic yet stylish pattern caught my eye, and the fit is perfect. I can see the designer's touch in every aspect of this shirt.", DatePost = new DateTime (2023, 8, 16) },
            new Review { ReviewRating = 4, NameCustomer = "Olivia P.", Comment = "As a UI/UX enthusiast, I value simplicity and functionality. This t-shirt not only represents those principles but also feels great to wear. It's evident that the designer poured their creativity into making this t-shirt stand out.", DatePost = new DateTime (2023, 8, 17) },
            new Review { ReviewRating = 4, NameCustomer = "Liam K.", Comment = "This t-shirt is a fusion of comfort and creativity. The fabric is soft, and the design speaks volumes about the designer's skill. It's like wearing a piece of art that reflects my passion for both design and fashion.", DatePost = new DateTime (2023, 8, 18) },
            new Review { ReviewRating = 4.5, NameCustomer = "Ava H.", Comment = "I'm not just wearing a t-shirt; I'm wearing a piece of design philosophy. The intricate details and thoughtful layout of the design make this shirt a conversation starter.", DatePost = new DateTime (2023, 8, 19) }
            };

            RelatedProducts = new List<Product>
            {
            new Product {Id = 1, ImageUrl = "/Images/PoloWithContrastTrims.png", Name = "Polo With Contrast Trims", Rating = 4, Unit = "$", Price = 212 },
            new Product {Id = 2, ImageUrl = "/Images/GradientGraphicT-shirt.png", Name = "Gradient Graphic T-shirt", Rating = 3.5, Unit = "$", Price = 145 },
            new Product {Id = 3, ImageUrl = "/Images/PoloWithTippingDetails.png", Name = "Polo With Tipping Details", Rating = 4.5, Unit = "$", Price = 180 },
            new Product {Id = 4, ImageUrl = "/Images/BlackStripedT-shirt.png", Name = "Black Striped T-shirt", Rating = 5, Unit = "$", Price = 120 }
            };

            ProductDetail = new ProductDetailViewModel
            {
                ProductId = 1,
                ProductName = "One Life Graphic T-shirt",
                Rating = 4.5,
                PriceDiscount = 260,
                PriceOriginal = 300,
                Description = "This graphic t-shirt which is perfect for any occasion. Crafted from a soft and breathable fabric, it offers superior comfort and style.",
                Colors = new List<string> { "#4F4631", "#314F4A", "#31344F" },
                Sizes = new List<string> { "Small", "Medium", "Large", "X-Large" },
                Photos = new List<string> { "/Images/OneLifeGraphicT-Shirt_Big.png", "/Images/OneLifeGraphicT-Shirt_Big_Back.png", "/Images/modeldress.png" }
            };          
        }
    }
}
