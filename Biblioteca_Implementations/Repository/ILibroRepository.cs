using System.Collections.Generic;
using Biblioteca_DAL.Model;

namespace Biblioteca_Implementations.Repository
{
    public interface ILibroRepository : IGenericRepository<Libro>
    {
        IEnumerable<Libro> GetByAutor(int id);
        bool Disponible(int id);

        IEnumerable<Libro> GetDisponibles();

        IEnumerable<Libro> GetPrestados();
    }
}
