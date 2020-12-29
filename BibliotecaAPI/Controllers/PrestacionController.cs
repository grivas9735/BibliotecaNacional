using System;
using Microsoft.AspNetCore.Mvc;
using Biblioteca_Implementations.BussinesLogic;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrestacionController : Controller
    {
        private readonly IPrestacionBL prestacionBL;

        public PrestacionController(IPrestacionBL _prestacionBL)
        {
            prestacionBL = _prestacionBL;
        }

        [HttpPost("retirar/{lectorId}/{libroId}")]
        public ActionResult RetirarLibro(int lectorId, int libroId)
        {
            try
            {
                prestacionBL.RetirarLibro(lectorId, libroId);
                return Ok($"Se presto el libro {libroId} al lector {lectorId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("devolver/{lectorId}/{libroId}")]
        public ActionResult DevolverLibro(int lectorId, int libroId)
        {
            try
            {
                prestacionBL.DevolverLibro(lectorId, libroId);
                return Ok($"Se devolvio el libro {libroId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
