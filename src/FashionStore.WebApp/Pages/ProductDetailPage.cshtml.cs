using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FashionStore.WebApp.Pages
{
    public class ProductDetailPageModel : PageModel
    {
        public List<string> Colors { get; set; } = new List<string>
        {
            "#4F4631", "#314F4A", "#31344F", 
        };
        public List<string> Sizes { get; set; }
        public void OnGet()
        {
            Sizes = new List<string> {  "Small", "Medium", "Large", "X-Large", };
        }
    }
}
