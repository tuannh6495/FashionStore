using Microsoft.AspNetCore.Mvc;
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

		}
            
    }
}
