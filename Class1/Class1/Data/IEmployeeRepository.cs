using Class1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1.Data
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAll();
        public Task<Employee> Get(int id);
        Task Put(Employee entity);
        public Task<Employee> Post(Employee entity);
        public Task Delete(Employee entity);
        public bool IsExsist(int id);
    }
}
