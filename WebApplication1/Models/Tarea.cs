using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Tarea
    {
        [Key]
        public int TareaID { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        //  ESTADO (ENUM)
        [Required]
        public EstadoTarea Estado { get; set; }

        // DIFICULTAD (ENUM)
        [Required]
        public DificultadTarea Dificultad { get; set; }

        public int TiempoEstimadoHoras { get; set; }

        // FK
        public int MetaID { get; set; }

        [ForeignKey("MetaID")]
        public Meta Meta { get; set; }

    }
}
