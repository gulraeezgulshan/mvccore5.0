using Class3.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Class3.Models
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(long id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(long id);
    }
}
