using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class AutorRepository : GenericRepository<Autor>, IAutorRepository
    {
        public AutorRepository(BibliotecaDBContext context) : base(context)
        {

        }
    }
}
