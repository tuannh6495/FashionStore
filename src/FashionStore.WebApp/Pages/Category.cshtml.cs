using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using FashionStore.WebApp.Common;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

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
        public PaginatedList<ProductDTO> CategoryProducts { get; set; }

        public int PageIndex { get; set; } = 1;
        int PageSize = 9;

        public CategoryModel(ICategoryService categoryService, ISizeService sizeService, IColorService colorService, IDressStyleService dressStyleService, IProductService productService) 
        {
            _categoryService = categoryService;
            _sizeService = sizeService;
            _colorService = colorService;
            _dressStyleService = dressStyleService;
            _productService = productService;
        }

        public async Task OnGetAsync(int? pageIndex)
        {
            Sizes = await _sizeService.GetAllSizesAsync();

            Categories = await _categoryService.GetAllCategoriesAsync();

            Colors = await _colorService.GetAllColorAsync();

            DressStyles = await _dressStyleService.GetAllDressStyleAsync();

            PageIndex = pageIndex ?? 1;

            if (int.TryParse(Request.Query["id"], out int id))
            {
                DressStyleName = await _dressStyleService.GetDressStyleNameAsync(id);

                var products = await _productService.GetDressStyleProductsAsync(id);

                CategoryProducts = PaginatedList<ProductDTO>.Create(products, PageIndex, PageSize);
            }
            else
            {
                RedirectToPage("/Error");
            }
        }
    }
}
