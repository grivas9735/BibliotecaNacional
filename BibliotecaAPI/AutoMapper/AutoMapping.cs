using AutoMapper;
using Biblioteca_Common.DTO;
using Biblioteca_DAL.Model;

namespace BibliotecaAPI.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Lector, DTOLector>();
            CreateMap<Libro, DTOLibro>();
            CreateMap<Editorial, DTOEditorial>();
            CreateMap<Autor, DTOAutor>();
            CreateMap<Prestacion, DTOPrestacion>();
            CreateMap<LectorCredencial, DTOLectorCredencial>();

            CreateMap<DTOLector, Lector>();
            CreateMap<DTOLibro, Libro>();
            CreateMap<DTOEditorial, Editorial>();
            CreateMap<DTOAutor, Autor>();
            CreateMap<DTOPrestacion, Prestacion>();
            CreateMap<DTOLectorCredencial, LectorCredencial>();
        }
    }
}