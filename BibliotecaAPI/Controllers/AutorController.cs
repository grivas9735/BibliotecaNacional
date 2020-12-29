using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Biblioteca_Implementations.BussinesLogic;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : Controller
    {
        private readonly IAutorBL autorBL;

        public AutorController(IAutorBL _autorBL)
        {
            autorBL = _autorBL;
        }

        [HttpGet("{id}/libros")]
        public ActionResult GetLibros(int id)
        {
            try
            {
                var libros = autorBL.GetLibros(id);
                return Ok((bool)libros?.Any() ? libros : "El autor no posee libros");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
