using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Hijo
    {
        public Hijo()
        {
            HijoCliente = new HashSet<HijoCliente>();
            MatriculaGuarderia = new HashSet<MatriculaGuarderia>();
        }

        public int IdHijo { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        public string Identificacion { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        [DisplayName("1er Apellido")]
        public string Apellido1 { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        [DisplayName("2do Apellido")]
        public string Apellido2 { get; set; }
        [Required(ErrorMessage = "Es requerido")]
        [DisplayName("Nació el?")]
        [DataType(DataType.Date)]
        public DateTime FechaDeNac { get; set; }

        public virtual ICollection<HijoCliente> HijoCliente { get; set; }
        public virtual ICollection<MatriculaGuarderia> MatriculaGuarderia { get; set; }
    }
}
