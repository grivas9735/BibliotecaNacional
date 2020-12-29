using System;

namespace Biblioteca_Implementations.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IAutorRepository Autor { get; }
        IEditorialRepository Editorial { get; }
        ILectorRepository Lector { get; }
        ILibroRepository Libro { get; }
        IPrestacionRepository Prestacion { get; }

        void Save();
    }
}
