using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;
using System.Collections.Generic;

namespace Biblioteca_BussinesLogic.BL
{
    public class AutorBL : BaseBL, IAutorBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public AutorBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public void Add(DTOAutor lector)
        {
            throw new System.NotImplementedException();
        }

        public DTOAutor Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTOAutor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
