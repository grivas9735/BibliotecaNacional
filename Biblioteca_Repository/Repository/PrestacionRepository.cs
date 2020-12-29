using System.Linq;
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

        public Prestacion GetByLectorLibro(int lectorId, int libroId)
        {
            return context.Prestacion
                .Where(x => x.LectorId == lectorId && x.LibroId == libroId)
                .OrderByDescending(x => x.FechaRetiro)
                .FirstOrDefault();
        }
    }
}