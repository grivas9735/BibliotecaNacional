using System.Collections.Generic;
using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_BussinesLogic.BL
{
    public class AutorBL : BaseBL, IAutorBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public AutorBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        public void Add(DTOAutor autor)
        {
            UnitOfWork.Autor.Add(Mapper.Map<Autor>(autor));
            UnitOfWork.Save();
        }

        public DTOAutor Get(int id)
        {
            var autor = UnitOfWork.Autor.Get(id);
            return Mapper.Map<DTOAutor>(autor);
        }

        public IEnumerable<DTOAutor> GetAll()
        {
            var autores = UnitOfWork.Autor.GetAll();
            return Mapper.Map<IEnumerable<DTOAutor>>(autores);
        }

        public IEnumerable<DTOLibro> GetLibros(int id)
        {
            var libros = UnitOfWork.Libro.GetByAutor(id);
            return Mapper.Map<IEnumerable<DTOLibro>>(libros);
        }

        public void Remove(int id)
        {
            UnitOfWork.Autor.Remove(id);
            UnitOfWork.Save();
        }
    }
}
