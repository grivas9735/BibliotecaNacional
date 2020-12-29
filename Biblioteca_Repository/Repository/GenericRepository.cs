using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Biblioteca_DAL;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly BibliotecaDBContext context;

        public GenericRepository(BibliotecaDBContext _context)
        {
            context = _context;
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking().ToList();
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Remove(int id)
        {
            var itemToRemove = context.Set<T>().Find(id);

            if (itemToRemove != null)
            {
                context.Entry(itemToRemove).State = EntityState.Deleted;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
