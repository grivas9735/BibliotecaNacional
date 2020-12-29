using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;
using System.Collections.Generic;

namespace Biblioteca_BussinesLogic.BL
{
    public class LibroBL : BaseBL, ILibroBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public LibroBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public IEnumerable<DTOLibro> GetDisponibles()
        {
            var disponibles = UnitOfWork.Libro.GetDisponibles();
            return Mapper.Map<IEnumerable<DTOLibro>>(disponibles);
        }

        public IEnumerable<DTOLibro> GetPrestados()
        {
            var prestados = UnitOfWork.Libro.GetPrestados();
            return Mapper.Map<IEnumerable<DTOLibro>>(prestados);
        }

        public void Add(DTOLibro lector)
        {
            throw new System.NotImplementedException();
        }

        public DTOLibro Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTOLibro> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
