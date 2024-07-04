using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEstacionamiento.Models
{
    public class Cliente
    {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            
            public int Id { get; set; }


            [Required(ErrorMessage = "Campo obligatorio")]
            [RegularExpression("^[0-9]{8}$", ErrorMessage = "El DNI debe ser numérico y tener exactamente 8 dígitos")]
            public string DNI { get; set; }
            
        
            [Required(ErrorMessage = "Campo obligatorio")]
            [Display(Name = "Nombre Completo")]
        public string Nombre { get; set; }
            
            [Required(ErrorMessage = "Campo obligatorio")]
            [Display(Name = "Celular")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "El celular debe ser numérico y tener exactamente 10 dígitos")]
        public string telefono { get; set; }


        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();



    }
}
