using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEstacionamiento.Models
{
    public class ReciboDePago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Número de reserva")]
        public int ReservaId { get; set; }

        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Precio por hora")]
        public decimal PrecioXHora { get; set; } // Precio por hora

        //[ForeignKey("Reserva")]
        public Reserva Reserva { get; set; }


        public ReciboDePago()
        {   
            Monto = CalcularMonto();
        }

        public decimal CalcularMonto()
        {
            DateTime fechaHoraIngreso = Reserva.FechaIngreso.ToDateTime(Reserva.HoraIngreso.Value);

            DateTime fechaHoraEgreso = Reserva.FechaEgreso.HasValue && Reserva.HoraEgreso.HasValue
                                   ? Reserva.FechaEgreso.Value.ToDateTime(Reserva.HoraEgreso.Value)
                                   : DateTime.Now;
            
             
            var duracion = fechaHoraEgreso - fechaHoraIngreso;
            var totalHoras = Math.Ceiling(duracion.TotalHours); // Redondeo para cobrar por horas completas

            Monto = (decimal)totalHoras * PrecioXHora;

            return Monto;
        }
    }
}
