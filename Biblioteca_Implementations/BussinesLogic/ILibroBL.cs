using System.Collections.Generic;
using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.BussinesLogic
{
    public interface ILibroBL
    {
        DTOLibro Get(int id);
        IEnumerable<DTOLibro> GetAll();
        void Add(DTOLibro lector);
        void Remove(int id);

        IEnumerable<DTOLibro> GetDisponibles();
        IEnumerable<DTOLibro> GetPrestados();
    }
}