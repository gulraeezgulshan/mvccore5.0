using Class1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1.Data
{
    public interface IDepartmentRepository
    {
        public Task<List<Department>> GetAll();
        public Task<Department> Get(int id);
        Task Put(Department entity);
        public Task<Department> Post(Department entity);
        public Task Delete(Department entity);
        public bool IsExsist(int id);
    }
}
