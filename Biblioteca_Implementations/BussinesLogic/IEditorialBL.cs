using System.Collections.Generic;
using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.BussinesLogic
{
    public interface IEditorialBL
    {
        DTOEditorial Get(int id);
        IEnumerable<DTOEditorial> GetAll();
        void Add(DTOEditorial lector);
        void Remove(int id);
    }
}