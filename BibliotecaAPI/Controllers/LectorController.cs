using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Biblioteca_Implementations.BussinesLogic;
using Biblioteca_Common.DTO;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorController : Controller
    {
        private readonly ILectorBL lectorBL;

        public LectorController(ILectorBL _lectorBL)
        {
            lectorBL = _lectorBL;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DTOLector>> GetAll()
        {
            try
            {
                return Ok(lectorBL.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<DTOLector> Get(int id)
        {
            try
            {
                var lector = lectorBL.Get(id);

                if (lector == null)
                    return NotFound();

                return Ok(lector);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Add([FromBody]DTOLector lector)
        {
            try
            {
                lectorBL.Add(lector);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Update([FromBody] DTOLector lector)
        {
            try
            {
                lectorBL.Update(lector);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] DTOLector lector)
        {
            try
            {
                lectorBL.Remove(lector);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                lectorBL.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
