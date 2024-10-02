using FashionStore.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDTO>> GetOurHappyCustomerReviewAsync();
        Task<IEnumerable<ReviewDTO>> GetProductReviewsAsync(int productId);
    }
}
