using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_DAL.Model
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibroId { get; set; }

        [ForeignKey("Autor")]
        public int AutorId { get; set; }

        [ForeignKey("Editorial")]
        public int EditorialId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaLanzamiento { get; set; }

        public Autor Autor { get; set; }
        public Editorial Editorial { get; set; }
    }
}
