using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Interfaces
{
    public interface IDressStyleService 
    {
        Task<IEnumerable<DressStyle>> GetAllDressStyleAsync();
        Task<string> GetDressStyleNameAsync(int dressStyleId);
    }
}
