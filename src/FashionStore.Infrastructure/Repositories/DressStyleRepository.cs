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
    public class DressStyleRepository : RepositoryBase<DressStyle>, IDressStyleRepository
    {
        public DressStyleRepository(FosDbContext context) : base(context)
        {
        }

        public async Task<string> GetDressStyleNameByIdAsync(int dressStyleId)
        {
            var dressStyle = await _context.DressStyles
                                       .FirstOrDefaultAsync(ds => ds.Id == dressStyleId);

            return dressStyle?.Name;
        }
    }
}
