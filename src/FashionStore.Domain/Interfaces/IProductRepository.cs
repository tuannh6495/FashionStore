using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        Task<IEnumerable<Product>> GetProductsForNewArrivalsAsync();
        Task<IEnumerable<Product>> GetProductsForTopSellingAsync();
        Task<IEnumerable<Product>> GetProductsForCasualAsync();
    }
}
