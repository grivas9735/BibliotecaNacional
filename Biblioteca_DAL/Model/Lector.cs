using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_DAL.Model
{
    public class Lector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LectorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(50)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        public DateTime? FechaAlta { get; set; }
    }
}
