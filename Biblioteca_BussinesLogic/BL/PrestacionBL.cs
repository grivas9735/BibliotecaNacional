using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;
using System.Collections.Generic;

namespace Biblioteca_BussinesLogic.BL
{
    public class PrestacionBL : BaseBL, IPrestacionBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public PrestacionBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public void Add(DTOPrestacion lector)
        {
            throw new System.NotImplementedException();
        }

        public DTOPrestacion Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTOPrestacion> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
