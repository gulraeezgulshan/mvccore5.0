using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class2.Data
{
    public interface IRepository<T> where T: class, IEntity
    {
        public Task<List<T>> GetAll();
        public Task<T> Get(int id);
        Task Put(T entity);
        public Task<T> Post(T entity);
        public Task Delete(T entity);
        public bool IsExsist(int id);
    }
}
