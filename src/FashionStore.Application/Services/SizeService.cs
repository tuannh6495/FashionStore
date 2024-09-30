using FashionStore.Application.Interfaces;
using FashionStore.Domain.Entities;
using FashionStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Services
{
    public class SizeService : ISizeService
    {
        private readonly ISizeRepository _sizeRepository;

        public SizeService(ISizeRepository sizeRepository) 
        {
            _sizeRepository = sizeRepository;
        }

        public async Task<IEnumerable<Size>> GetAllSizesAsync()
        {
            return await _sizeRepository.GetAllAsync();
        }
    }
}
