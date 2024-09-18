using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductVC;

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
                new Product { ImageUrl = "/Images/GradientGraphicT-shirt.png", Name = "Gradient Graphic T-shirt", Rating = 3.5, Unit = "$", Price = 145 },
                new Product { ImageUrl = "/Images/PoloWithTippingDetails.png", Name = "Polo with Tipping Details", Rating = 4.5, Unit = "$", Price = 180 },
                new Product { ImageUrl = "/Images/BlackStripedT-shirt.png", Name = "Black Striped T-shirt", Rating = 5, Unit = "$", Price = 120 },
                new Product { ImageUrl = "/Images/SFJ.png", Name = "Skinny Fit Jeans", Rating = 3.5, Unit = "$", Price = 240 },
                new Product { ImageUrl = "/Images/CS.png", Name = "Checkered Shirt", Rating = 4.5, Unit = "$", Price = 180 },
                new Product { ImageUrl = "/Images/SST.png", Name = "Sleeve Striped T-shirt", Rating = 4.5, Unit = "$", Price = 130 },
                new Product { ImageUrl = "/Images/VerticalStripedShirt.png", Name = "Vertical Striped Shirt", Rating = 5, Unit = "$", Price = 212 },
                new Product { ImageUrl = "/Images/CourageGraphicT-shirt.png", Name = "Courage Graphic T-shirt", Rating = 4, Unit = "$", Price = 145 },
                new Product { ImageUrl = "/Images/LooseFitBermudaShorts.png", Name = "Loose Fit Bermuda Shorts", Rating = 3, Unit = "$", Price = 80 }
            };

        }

    }
}
