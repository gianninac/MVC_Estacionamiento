using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEstacionamiento.Models
{
    public class Espacio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Número")]
        public int Id { get; set; }


        [Required]
        public bool Disponible { get; set; }

        // Constructor para inicializar la propiedad Disponible con true
        public Espacio()
        {
            Disponible = true;
        }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
