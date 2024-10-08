using FashionStore.Application.DTOs;
using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<IEnumerable<ProductDTO>> GetNewArrivalProductsAsync();
        Task<IEnumerable<ProductDTO>> GetTopSellingProductsAsync();
        Task<IEnumerable<ProductDTO>> GetDressStyleProductsAsync(int dressStyleId);
        Task<ProductDetailDTO> GetProductDetailAsync(int productId);
        Task<IEnumerable<ProductDTO>> GetRelatedProductsAsync(int productId);
        Task<ProductDTO> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductDTO>> FindProductsAsync(Expression<Func<Product, bool>> predicate);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(Product product);
        Task DeleteRangeProductsAsync(IEnumerable<Product> products);
    }
}
