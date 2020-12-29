using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class EditorialRepository : GenericRepository<Editorial>, IEditorialRepository
    {
        public EditorialRepository(BibliotecaDBContext context) : base(context)
        {

        }
    }
}
