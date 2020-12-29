using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class LibroRepository : GenericRepository<Libro>, ILibroRepository
    {
        public LibroRepository(BibliotecaDBContext context) : base(context)
        {

        }
    }
}