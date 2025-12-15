using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace WebApplication1.Models
{
    public class Meta
    {
        [Key]
        public int MetaID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Titulo { get; set; }

   
        [Required]
        public CategoriaMeta Categoria { get; set; }

        // FECHA AUTOMÁTICA
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

      
        [Required]
        public PrioridadMeta Prioridad { get; set; }

 
        [Required]
        public EstadoMeta Estado { get; set; }

        //  RELACIÓN 1 → N
        public ICollection<Tarea> Tareas { get; set; }
    }
}
