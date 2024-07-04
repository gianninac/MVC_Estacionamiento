using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEstacionamiento.Models
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Número de Cliente")]
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Número de espacio")]
        [ForeignKey("Espacio")]
        public int EspacioId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly FechaIngreso { get; set; }

        
        [Display(Name = "Fecha de Egreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateOnly? FechaEgreso { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Hora de Ingreso")]
        [RegularExpression(@"\d{2}:\d{2}", ErrorMessage = "El formato de la hora debe ser HH:mm")]
        public TimeOnly? HoraIngreso { get; set; }

        [Display(Name = "Hora de Egreso")]
        [RegularExpression(@"\d{2}:\d{2}", ErrorMessage = "El formato de la hora debe ser HH:mm")]
        public TimeOnly? HoraEgreso { get; set; }

        public Cliente? Cliente { get; set; }
        public Espacio? Espacio { get; set; }
    }
}
