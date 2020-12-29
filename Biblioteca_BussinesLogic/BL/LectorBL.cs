using System.Collections.Generic;
using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_BussinesLogic.BL
{
    public class LectorBL : BaseBL, ILectorBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public LectorBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public IEnumerable<DTOLector> GetAll()
        {
            var lectores = UnitOfWork.Lector.GetAll();
            return Mapper.Map<IEnumerable<DTOLector>>(lectores);
        }

        public DTOLector Get(int id)
        {
            var lector = UnitOfWork.Lector.Get(id);
            return Mapper.Map<DTOLector>(lector);
        }

        public void Add(DTOLector lector)
        {
            UnitOfWork.Lector.Add(Mapper.Map<Lector>(lector));
            UnitOfWork.Save();
        }

        public void Remove(int id)
        {
            UnitOfWork.Lector.Remove(id);
            UnitOfWork.Save();
        }

        public void Remove(DTOLector lector)
        {
            UnitOfWork.Lector.Remove(Mapper.Map<Lector>(lector));
            UnitOfWork.Save();
        }

        public void Update(DTOLector lector)
        {
            UnitOfWork.Lector.Update(Mapper.Map<Lector>(lector));
            UnitOfWork.Save();
        }
    }
}
