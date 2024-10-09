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
										 .Include(product => product.Discount)
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
										 .Include(product => product.Discount)
										 .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsByDressStyleAsync(int dressStyleId)
        {
            var productIds = await _context.DressStylePs
                                           .Where(DressStyleP => DressStyleP.DressStyleId == dressStyleId)
                                           .Select(DressStyleP => DressStyleP.ProductId)
                                           .ToListAsync();
            var products = await _context.Products
                                         .Where(product => productIds.Contains(product.Id))
										 .Include(product => product.Discount)
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
				.Include(product => product.Discount)
				.FirstOrDefaultAsync(p => p.Id == productId);
            product.SizePs = product.SizePs.OrderBy(sp => sp.SizeId).ToList();
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsForRelatedAsync(int categoryId, int excludeProductId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId && p.Id != excludeProductId)
				.Include(product => product.Discount)
				.Take(4) 
                .ToListAsync();
        }

    }
}
