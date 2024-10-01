using AutoMapper;
using FashionStore.Application.DTOs;
using FashionStore.Application.Interfaces;
using FashionStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReviewDTO>> GetOurHappyCustomerReviewAsync()
        {
            var reviews = await _reviewRepository.GetReviewsForOurHappyCustomersAsync();
            return _mapper.Map<IEnumerable<ReviewDTO>>(reviews);
        }
    }
}
