using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class LectorRepository : GenericRepository<Lector>, ILectorRepository
    {
        public LectorRepository(BibliotecaDBContext context) : base(context)
        {

        }
    }
}
