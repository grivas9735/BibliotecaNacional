using System.Collections.Generic;

namespace Biblioteca_Implementations.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Update(T entity);
        void Add(T entity);
        void Remove(T entity);
        void Remove(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Save();
    }
}
