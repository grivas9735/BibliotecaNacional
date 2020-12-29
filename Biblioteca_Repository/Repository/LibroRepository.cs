using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Biblioteca_DAL;
using Biblioteca_DAL.Model;
using Biblioteca_Implementations.Repository;

namespace Biblioteca_Repository.Repository
{
    public class LibroRepository : GenericRepository<Libro>, ILibroRepository
    {
        public LibroRepository(BibliotecaDBContext context) : base(context)
        {

        }

        public IEnumerable<Libro> GetDisponibles()
        {
            var prestados = context.Prestacion
                .Where(x => x.FechaDevolucion == null)
                .Select(x => x.LibroId)
                .Distinct()
                .ToList();

            return context.Libro.Where(x => !prestados.Contains(x.LibroId));
        }

        public IEnumerable<Libro> GetPrestados()
        {
            var prestados = context.Prestacion
                .Where(x => x.FechaDevolucion == null)
                .Select(x => x.LibroId)
                .Distinct()
                .ToList();

            return context.Libro.Where(x => prestados.Contains(x.LibroId));
        }

        public IEnumerable<Libro> GetByAutor(int id)
        {
            return context.Libro.AsNoTracking().Where(x => x.AutorId == id);
        }

        public bool Disponible(int id)
        {
            return !context.Prestacion.Any(x => x.LibroId == id && x.FechaDevolucion == null);
        }
    }
}