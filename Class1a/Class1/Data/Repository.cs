using Class1a.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Data
{
    public class Repository<T, C> : IRepository<T> where T : class, IEntity where C : DbContext
    {

        private readonly C _context;

        public Repository(C context)
        {
            _context = context;
        }


        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public bool IsExsist(int id)
        {
            return _context.Set<T>().Any(e=> e.Id == id);
        }

        public async Task<T> Post(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Put(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }

}
