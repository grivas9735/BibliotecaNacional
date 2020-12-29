using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_DAL.Model
{
    public class LectorCredencial
    {
        [ForeignKey("Lector")]
        public int LectorCredencialId { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserPassword { get; set; }

        public Lector Lector { get; set; }
    }
}
