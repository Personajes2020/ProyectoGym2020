using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class RecargaMonederoV
    {
        [Key]
        public int IdRecargaMv { get; set; }
        [DisplayName("Id Monedero")]
        [Required(ErrorMessage = "Necesita seleccionar el monedero que desea recargar")]
        public int IdMonedero { get; set; }
        [Required(ErrorMessage = "Digite el monto a recargar")]
        public double Monto { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public virtual Monedero IdMonederoNavigation { get; set; }
    }
}
