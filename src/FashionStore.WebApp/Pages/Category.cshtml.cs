using FashionStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FashionStore.WebApp.Pages
{
    public class CategoryModel : PageModel
    {
        public List<string> Sizes { get; set; }
        public List<(string Name, string Page)> Categories { get; private set; }

        public List<string> Category { get; set; }

        public List<string> Colors { get; set; } = new List<string>
        {
            "#00C12B", "#F50606", "#F5DD06", "#F57906", "#06CAF5",
            "#063AF5", "#7D06F5", "#F506A4", "#FFFFFF", "#000000"
        };

        public List<Product> Casual { get; set; }

        public void OnGet()
        {
            Sizes = new List<string> { "XX-Small", "X-Small", "Small", "Medium", "Large", "X-Large", "XX-Large", "3X-Large", "4X-Large" };
            Categories = new List<(string Name, string Page)>
            {
                ("Casual", "/CasualPage"),
                ("Formal", "/FormalPage"),
                ("Party", "/PartyPage"),
                ("Gym", "/GymPage")
            };

            Category = new List<string> { "T-shirts", "Shorts", "Shirts", "Hoodie", "Jeans" };

            Casual = new List<Product>
            {
                new Product ( new List<string> { "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png", "/Images/GradientGraphicT-shirt.png" }, "Gradient Graphic T-shirt" ) { AvgRating = 3.5m, Price = 145 },
                new Product ( new List<string> { "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png", "/Images/PoloWithTippingDetails.png" }, "Polo with Tipping Details" ) { AvgRating = 4.5m, Price = 180 },
                new Product ( new List<string> { "/Images/BlackStripedT - shirt.png", "/Images/BlackStripedT - shirt.png", "/Images/BlackStripedT - shirt.png" }, "Black Striped T-shirt" ) { AvgRating = 5m, Price = 120 },
                new Product ( new List<string> { "/Images/SFJ.png", "/Images/SFJ.png", "/Images/SFJ.png" }, "Skinny Fit Jeans" ) { AvgRating = 3.5m, Price = 240 },
                new Product ( new List<string> { "/Images/CS.png", "/Images/CS.png", "/Images/CS.png" }, "Checkered Shirt" ) { AvgRating = 4.5m, Price = 180 },
                new Product ( new List<string> { "/Images/SST.png", "/Images/SST.png", "/Images/SST.png" }, "Sleeve Striped T-shirt" ) { AvgRating = 4.5m, Price = 130 },
                new Product ( new List<string> { "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png", "/Images/VerticalStripedShirt.png" }, "Vertical Striped Shirt" ) { AvgRating = 5m, Price = 212 },
                new Product ( new List<string> { "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png", "/Images/CourageGraphicT-shirt.png" }, "Courage Graphic T-shirt" ) { AvgRating = 4m, Price = 145 },
                new Product ( new List<string> { "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png", "/Images/LooseFitBermudaShorts.png" }, "Loose Fit Bermuda Shorts" ) { AvgRating = 3m, Price = 80 }
            };

        }
    }
}
