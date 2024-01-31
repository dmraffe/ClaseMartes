using Ecommerce.Application.Contract.Repository;
using Ecommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implementation.Repository
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : TableBase
    {
        EcommerceDbContext _ecommerceDbContext;
        public BaseRepositoryAsync(EcommerceDbContext ecommerceDbContext) {
            _ecommerceDbContext = ecommerceDbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _ecommerceDbContext.Set<T>().Add(entity);
          await  _ecommerceDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _ecommerceDbContext.Set<T>().Remove(entity);
            await _ecommerceDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
          return await _ecommerceDbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated)
        {
            return await _ecommerceDbContext.Set<T>().Where(predicated).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _ecommerceDbContext.Set<T>().Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _ecommerceDbContext.Set<T>().Update(entity);
            await _ecommerceDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
