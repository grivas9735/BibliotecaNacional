using System.Collections.Generic;
using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.BussinesLogic
{
    public interface IPrestacionBL
    {
        DTOPrestacion Get(int id);
        IEnumerable<DTOPrestacion> GetAll();
        void Add(DTOPrestacion lector);
        void Remove(int id);
    }
}