using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEstacionamiento.Models
{
    public class Vehiculo
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "DNI Cliente")]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [Key]
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Patente { get; set; }
        
        public string? Marca { get; set; }

        public string? Modelo { get; set; }


        [EnumDataType(typeof(TipoVehiculo))]
        public TipoVehiculo? Tipo { get; set; }

        public Cliente? Propietario { get; set; }
    }


}
