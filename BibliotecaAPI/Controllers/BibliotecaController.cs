using System;
using Biblioteca_Implementations.BussinesLogic;
using BibliotecaAPI.Gestores;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/biblioteca")]
    public class BibliotecaController : Controller
    {
        private readonly IPrestacionBL prestacionBL;

        public BibliotecaController(IPrestacionBL _prestacionBL)
        {
            prestacionBL = _prestacionBL;
        }

        [HttpPost("suscribe/{lectorId}/{libroId}")]
        public ActionResult Suscribe(int lectorId, int libroId)
        {
            try
            {
                Biblioteca biblioteca = Biblioteca.GetInstance();
                biblioteca.Suscribe(lectorId, libroId);
                return Ok($"El lector {lectorId} se suscribio al libro {libroId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("unsuscribe/{lectorId}/{libroId}")]
        public ActionResult UnSuscribe(int lectorId, int libroId)
        {
            try
            {
                Biblioteca biblioteca = Biblioteca.GetInstance();
                biblioteca.UnSuscribe(lectorId, libroId);
                return Ok($"El lector {lectorId} se des-suscribio al libro {libroId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("retirar/{lectorId}/{libroId}")]
        public ActionResult RetirarLibro(int lectorId, int libroId)
        {
            try
            {
                bool retiradoOk = prestacionBL.RetirarLibro(lectorId, libroId);

                if (!retiradoOk)
                    return BadRequest($"El libro {libroId} no esta disponible");

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

                Biblioteca biblioteca = Biblioteca.GetInstance();
                biblioteca.NotifyLectores(libroId);

                return Ok($"Se devolvio el libro {libroId}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
