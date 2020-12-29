using System;

namespace Biblioteca_Common.DTO
{
    public class DTOLector
    {
        public int LectorId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public DateTime? FechaAlta { get; set; }
    }
}
