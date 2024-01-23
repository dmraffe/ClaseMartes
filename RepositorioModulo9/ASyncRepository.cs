using Microsoft.EntityFrameworkCore;
using ModeloModulo9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioModulo9
{
    public class ASyncRepository<T> : IAsyncRepositorio<T> where T : TablaBase
    {
        private DbContext _dbContext;

        public ASyncRepository(DbContext dbContext)
        {
           _dbContext  = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
           await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
           var lista = await _dbContext.Set<T>().ToListAsync();
            return lista;
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicated)
        {
            var lista = await _dbContext.Set<T>().Where(predicated).ToListAsync();
            return lista;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var lista = await _dbContext.Set<T>().Where(a => a.Id == id).FirstOrDefaultAsync();
            return lista;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
    }
}
