using System;

namespace Biblioteca_Common.DTO
{
    public class DTOLibro
    {
        public int LibroId { get; set; }

        public int AutorId { get; set; }

        public int EditorialId { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaLanzamiento { get; set; }
    }
}
