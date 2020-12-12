using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class1a.Data
{
    public interface IRepository<E> where E: class
    {
        public Task<List<E>> GetAll();
        public Task<E> Get(int id);
        Task Put(E entity);
        public Task<E> Post(E entity);
        public Task Delete(E entity);
        public bool IsExsist(int id);
    }
}
