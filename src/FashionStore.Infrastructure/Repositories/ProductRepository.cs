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
    }
}
