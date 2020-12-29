using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_DAL.Model
{
    public class Editorial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EditorialId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
