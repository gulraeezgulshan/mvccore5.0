using Class1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Delete(Department entity)
        {
            _context.Departments.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> Get(int id)
        {
            var entity = await _context.Departments.FindAsync(id);
            return entity;
        }

        public async Task<Department> Post(Department entity)
        {
            _context.Departments.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Put(Department entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public bool IsExsist(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
