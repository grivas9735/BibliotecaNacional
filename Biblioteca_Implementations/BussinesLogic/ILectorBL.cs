using System.Collections.Generic;
using Biblioteca_Common.DTO;

namespace Biblioteca_Implementations.BussinesLogic
{
    public interface ILectorBL
    {
        DTOLector Get(int id);
        IEnumerable<DTOLector> GetAll();
        void Add(DTOLector lector);
        void Remove(int id);
        void Remove(DTOLector lector);
        void Update(DTOLector lector);
    }
}