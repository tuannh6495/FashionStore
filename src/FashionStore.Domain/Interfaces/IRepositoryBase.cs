﻿using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Domain.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync(); 
        Task<T> GetByIdAsync(int id); 
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate); 
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);  
        Task UpdateAsync(T entity);  
        Task DeleteAsync(T entity);  
        Task DeleteRangeAsync(IEnumerable<T> entities); 
    }
}
