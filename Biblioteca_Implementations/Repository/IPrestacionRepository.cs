using Biblioteca_DAL.Model;

namespace Biblioteca_Implementations.Repository
{
    public interface IPrestacionRepository : IGenericRepository<Prestacion>
    {
        Prestacion GetByLectorLibro(int lectorId, int libroId);
    }
}
