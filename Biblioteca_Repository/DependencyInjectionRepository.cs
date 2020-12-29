using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca_DAL;
using Biblioteca_Implementations.Repository;
using Biblioteca_Repository.Repository;

namespace Biblioteca_Repository
{
    public static class DependencyInjectionRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<IEditorialRepository, EditorialRepository>();
            services.AddTransient<ILectorRepository, LectorRepository>();
            services.AddTransient<ILibroRepository, LibroRepository>();
            services.AddTransient<IPrestacionRepository, PrestacionRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<BibliotecaDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
