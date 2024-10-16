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
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(FosDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetReviewsForOurHappyCustomersAsync()
        {
            return await _context.Reviews
                             .Include(r => r.AppUser)
                             .Where(r => r.ReviewRating >= 4)
                             .OrderByDescending(r => r.ReviewRating) 
                             .ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewsForProductAsync(int productId)
        {
            return await _context.Reviews
                    .Include(r => r.AppUser)
                    .Where(r => r.ProductId == productId)
                    .ToListAsync();
        }
    }
}
