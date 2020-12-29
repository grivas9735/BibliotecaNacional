using Biblioteca_DAL;
using Biblioteca_Implementations.Repository;
using Biblioteca_Repository.Repository;

namespace Biblioteca_Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BibliotecaDBContext context;

        public IAutorRepository Autor { get; }

        public IEditorialRepository Editorial { get; }

        public ILectorRepository Lector { get; }

        public ILibroRepository Libro { get; }

        public IPrestacionRepository Prestacion { get; }

        public UnitOfWork(BibliotecaDBContext _context)
        {
            context = _context;

            Autor = new AutorRepository(context);
            Editorial = new EditorialRepository(context);
            Lector = new LectorRepository(context);
            Libro = new LibroRepository(context);
            Prestacion = new PrestacionRepository(context);
        }

        public void Save() => context.SaveChanges();

        public void Dispose() => context.Dispose();
    }
}
