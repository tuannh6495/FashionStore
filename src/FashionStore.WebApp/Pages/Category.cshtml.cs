using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FashionStore.WebApp.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        private readonly ISizeService _sizeService;
        private readonly IColorService _colorService;
        private readonly IDressStyleService _dressStyleService;
        private readonly IProductService _productService;

        public IEnumerable<Size> Sizes { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<DressStyle> DressStyles { get; set; }
        public string DressStyleName { get; set; }
        public IEnumerable<ProductDTO> CategoryProducts { get; set; }

        public CategoryModel(ICategoryService categoryService, ISizeService sizeService, IColorService colorService, IDressStyleService dressStyleService, IProductService productService) 
        {
            _categoryService = categoryService;
            _sizeService = sizeService;
            _colorService = colorService;
            _dressStyleService = dressStyleService;
            _productService = productService;
        }

        public async Task OnGetAsync()
        {
            Sizes = await _sizeService.GetAllSizesAsync();

            Categories = await _categoryService.GetAllCategoriesAsync();

            Colors = await _colorService.GetAllColorAsync();

            DressStyles = await _dressStyleService.GetAllDressStyleAsync();

            if (int.TryParse(Request.Query["id"], out int id))
            {
                DressStyleName = await _dressStyleService.GetDressStyleNameAsync(id);
                CategoryProducts = await _productService.GetDressStyleProductsAsync(id);
            }
            else
            {
                RedirectToPage("/Error");
            }
        }
    }
}
