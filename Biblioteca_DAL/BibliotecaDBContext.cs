using Microsoft.EntityFrameworkCore;
using Biblioteca_DAL.Model;

namespace Biblioteca_DAL
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options)
        {

        }

        public DbSet<Lector> Lector { get; set; }
        public DbSet<LectorCredencial> LectorCredencial { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Editorial> Editorial { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Prestacion> Prestacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
