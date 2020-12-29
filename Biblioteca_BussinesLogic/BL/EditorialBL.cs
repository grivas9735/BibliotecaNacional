using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;
using System.Collections.Generic;

namespace Biblioteca_BussinesLogic.BL
{
    public class EditorialBL : BaseBL, IEditorialBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public EditorialBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public void Add(DTOEditorial lector)
        {
            throw new System.NotImplementedException();
        }

        public DTOEditorial Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<DTOEditorial> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
