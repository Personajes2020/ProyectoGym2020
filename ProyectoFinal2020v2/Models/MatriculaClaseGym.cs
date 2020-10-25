using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class MatriculaClaseGym
    {
        public int IdMatriculaGym { get; set; }
        [DisplayName("Cliente")]
        [Required(ErrorMessage ="Se necesita el cliente")]
        public int IdCliente { get; set; }
        [DisplayName("Clase")]
        [Required(ErrorMessage = "Se necesita la clase")]
        public int IdClaseGym { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;

        public virtual ClaseGym IdClaseGymNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
