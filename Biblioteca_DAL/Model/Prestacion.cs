using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_DAL.Model
{
    public class Prestacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrestacionId { get; set; }

        [ForeignKey("Libro")]
        public int LibroId { get; set; }

        [ForeignKey("Lector")]
        public int LectorId { get; set; }

        public DateTime FechaRetiro { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public Libro Libro { get; set; }

        public Lector Lector { get; set; }
    }
}
