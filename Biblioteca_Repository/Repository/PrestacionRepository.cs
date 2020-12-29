using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class PrestacionRepository : GenericRepository<Prestacion>, IPrestacionRepository
    {
        public PrestacionRepository(BibliotecaDBContext context) : base(context)
        {

        }
    }
}