using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2.Data
{
    public class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity where TContext : DbContext
    {
        private readonly TContext _context;

        public Repository(TContext context)
        {
            _context = context;
        }
        public async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Get(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public bool IsExsist(int id)
        {
            return _context.Set<TEntity>().Any(e => e.Id == id);
        }

        public async Task<TEntity> Post(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Put(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
