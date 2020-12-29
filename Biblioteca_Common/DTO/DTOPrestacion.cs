using System;

namespace Biblioteca_Common.DTO
{
    public class DTOPrestacion
    {
        public int PrestacionId { get; set; }

        public int LibroId { get; set; }

        public int LectorId { get; set; }

        public DateTime FechaRetiro { get; set; }

        public DateTime FechaDevolucion { get; set; }
    }
}
