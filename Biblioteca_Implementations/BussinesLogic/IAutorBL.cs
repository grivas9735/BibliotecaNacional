using System.Collections.Generic;
using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.BussinesLogic
{
    public interface IAutorBL
    {
        DTOAutor Get(int id);
        IEnumerable<DTOAutor> GetAll();
        void Add(DTOAutor lector);
        void Remove(int id);
    }
}
