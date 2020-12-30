using System;
using AutoMapper;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_BussinesLogic.BL
{
    public class PrestacionBL : BaseBL, IPrestacionBL
    {
        private readonly IUnitOfWork UnitOfWork;

        public PrestacionBL(IUnitOfWork _uow, IMapper _mapper) : base(_mapper)
        {
            UnitOfWork = _uow;
        }

        /// <summary>
        /// Devuelve 'true' si se pudo retirar el libro. Devuelve 'false' si el libro no está disponible 
        /// </summary>
        /// <param name="lectorId"></param>
        /// <param name="libroId"></param>
        /// <returns></returns>
        public bool RetirarLibro(int lectorId, int libroId)
        {
            if (UnitOfWork.Libro.Get(libroId) == null)
                throw new Exception($"El libro {libroId} no existe");

            if (UnitOfWork.Lector.Get(lectorId) == null)
                throw new Exception($"El lector {lectorId} no existe");

            if (!UnitOfWork.Libro.Disponible(libroId))
                return false;

            UnitOfWork.Prestacion.Add(new Prestacion
            {
                LectorId = lectorId,
                LibroId = libroId,
                FechaRetiro = DateTime.Now
            });

            UnitOfWork.Save();
            return true;
        }

        /// <summary>
        /// Devuelve un libro. Lanza excepcion si el libro nunca fue prestado al lector
        /// </summary>
        /// <param name="lectorId"></param>
        /// <param name="libroId"></param>
        public void DevolverLibro(int lectorId, int libroId)
        {
            if (UnitOfWork.Libro.Disponible(libroId))
                throw new Exception($"El libro {libroId} no esta prestado");

            var prestacion = UnitOfWork.Prestacion.GetByLectorLibro(lectorId, libroId);

            if (prestacion == null)
                throw new Exception($"El libro {libroId} nunca fue prestado al lector {lectorId}");

            if (prestacion.FechaDevolucion != null)
                throw new Exception($"El libro {libroId} ya fue devuelto por el lector {lectorId}");

            prestacion.FechaDevolucion = DateTime.Now;
            UnitOfWork.Prestacion.Update(prestacion);
            UnitOfWork.Save();
        }
    }
}
