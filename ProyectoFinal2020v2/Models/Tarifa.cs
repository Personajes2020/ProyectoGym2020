using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Tarifa
    {
        public Tarifa()
        {
            Cliente = new HashSet<Cliente>();
        }
        public int IdTarifa { get; set; }
        [Required(ErrorMessage = "Es obligatorio el precio de la tarifa.")]
        [DisplayName("Precio de la Tarifa")]
        public double PrecioTarifa { get; set; }
        [Required(ErrorMessage = "Es obligatorio Bebes.")]
        public int? Bebes { get; set; }
        [Required(ErrorMessage = "Es obligatoria la Duracion.")]
        public string Duracion { get; set; }
        [Required(ErrorMessage = "Es obligatorio el Estado.")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Es obligatorio la Descripcion.")]
        public string Descripcion { get; set; }

       
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
