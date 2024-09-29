using AutoMapper;
using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<ProductDTO> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public async Task<IEnumerable<ProductDTO>> FindProductsAsync(Expression<Func<Product, bool>> predicate)
        {
            var products = await _productRepository.FindAsync(predicate);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task AddRangeProductsAsync(IEnumerable<Product> products)
        {
            await _productRepository.AddRangeAsync(products);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteProductAsync(Product product)
        {
            await _productRepository.DeleteAsync(product);
        }

        public async Task DeleteRangeProductsAsync(IEnumerable<Product> products)
        {
            await _productRepository.DeleteRangeAsync(products);
        }

        public async Task<IEnumerable<ProductDTO>> GetNewArrivalProductsAsync()
        {
            var products = await _productRepository.GetProductsForNewArrivalsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<IEnumerable<ProductDTO>> GetTopSellingProductsAsync()
        {
            var products = await _productRepository.GetProductsForTopSellingAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}
