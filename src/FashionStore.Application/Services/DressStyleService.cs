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
    public class DressStyleService : IDressStyleService
    {
        private readonly IDressStyleRepository _dressStyleRepository;

        public DressStyleService(IDressStyleRepository dressStyleRepository)
        {
            _dressStyleRepository = dressStyleRepository;
        }

        public async Task<IEnumerable<DressStyle>> GetAllDressStyleAsync()
        {
            return await _dressStyleRepository.GetAllAsync();
        }
    }
}
