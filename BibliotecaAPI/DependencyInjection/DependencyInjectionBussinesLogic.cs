using Microsoft.Extensions.DependencyInjection;
using Biblioteca_BussinesLogic.BL;
using Biblioteca_Implementations.BussinesLogic;

namespace BibliotecaAPI.DependencyInjection
{
    public static class DependencyInjectionBussinesLogic
    {
        public static IServiceCollection AddBussinesLogic(this IServiceCollection services)
        {
            services.AddTransient<IAutorBL, AutorBL>();
            services.AddTransient<IEditorialBL, EditorialBL>();
            services.AddTransient<ILectorBL, LectorBL>();
            services.AddTransient<ILibroBL, LibroBL>();
            services.AddTransient<IPrestacionBL, PrestacionBL>();

            return services;
        }
    }
}
