using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using FashionStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(FosDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsForNewArrivalsAsync()
        {
            var productIds = await _context.OutPs
                                           .Where(outP => outP.OutstandingId == 2)
                                           .Select(outP => outP.ProductId)
                                           .ToListAsync();
            var products = await _context.Products
                                         .Where(product => productIds.Contains(product.Id))
                                         .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsForTopSellingAsync()
        {
            var productIds = await _context.OutPs
                                           .Where(outP => outP.OutstandingId == 3)
                                           .Select(outP => outP.ProductId)
                                           .ToListAsync();
            var products = await _context.Products
                                         .Where(product => productIds.Contains(product.Id))
                                         .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsForCasualAsync()
        {
            var productIds = await _context.DressStylePs
                                           .Where(DressStyleP => DressStyleP.DressStyleId == 1)
                                           .Select(DressStyleP => DressStyleP.ProductId)
                                           .ToListAsync();
            var products = await _context.Products
                                         .Where(product => productIds.Contains(product.Id))
                                         .ToListAsync();
            return products;
        }

        public async Task<Product> GetProductsWithDetailAsync(int productId)
        {
            var product = await _context.Products
                .Include(p => p.ColorPs)
                    .ThenInclude(cp => cp.Color)
                .Include(p => p.SizePs)
                    .ThenInclude(sp => sp.Size)
                .FirstOrDefaultAsync(p => p.Id == productId);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsForRelatedAsync(int categoryId, int excludeProductId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId && p.Id != excludeProductId)
                .Take(4) 
                .ToListAsync();
        }

    }
}
