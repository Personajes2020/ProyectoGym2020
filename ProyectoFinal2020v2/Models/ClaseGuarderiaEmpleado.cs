using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGuarderiaEmpleado
    {
        public int IdClaseGuarderiaEmpleado { get; set; }
        [DisplayName("Clase")]
        [Required(ErrorMessage ="Se requiere la clase")]
        public int IdClaseGuarderia { get; set; }
        [DisplayName("Empleado")]
        [Required(ErrorMessage = "Es obligatorio ingresar el empleado")]
        public int IdEmpleado { get; set; }

        public virtual ClaseGuarderia IdClaseGuarderiaNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
