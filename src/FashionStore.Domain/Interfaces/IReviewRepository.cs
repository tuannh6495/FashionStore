﻿using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Interfaces
{
    public interface IReviewRepository : IRepositoryBase<Review>
    {
        Task<IEnumerable<Review>> GetReviewsForOurHappyCustomersAsync();
        Task<IEnumerable<Review>> GetReviewsForProductAsync(int productId);
    }
}
