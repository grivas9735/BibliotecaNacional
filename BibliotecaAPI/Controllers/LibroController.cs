using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Common.DTO;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroController : Controller
    {
        private readonly ILibroBL libroBL;
        
        public LibroController(ILibroBL _libroBL)
        {
            libroBL = _libroBL;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DTOLibro>> GetAll()
        {
            try
            {
                return Ok(libroBL.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("disponibles")]
        public ActionResult<IEnumerable<DTOLibro>> GetDisponibles()
        {
            try
            {
                var disponibles = libroBL.GetDisponibles();

                if (!disponibles.Any())
                    return NotFound("No hay libros disponibles");

                return Ok(disponibles);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("prestados")]
        public ActionResult<IEnumerable<DTOLibro>> GetPrestados()
        {
            try
            {
                var prestados = libroBL.GetPrestados();

                if (!prestados.Any())
                    return NotFound("No hay libros prestados");

                return Ok(prestados);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
