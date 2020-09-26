using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            ClaseGuarderiaEmpleado = new HashSet<ClaseGuarderiaEmpleado>();
        }

        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "Es obligatorio la identificacion.")]
        public string Identificacion { get; set; }
        [Required(ErrorMessage = "Es obligatorio el nombre.")]
        public string Nombre { get; set; }
        [DisplayName("Primer apellido")]
        [Required(ErrorMessage = "Es obligatorio el primer apellido.")]
        public string Apellido1 { get; set; }
        [DisplayName("Segundo apellido")]
        [Required(ErrorMessage = "Es obligatorio el segundo apellido.")]
        public string Apellido2 { get; set; }
        [DisplayName("Fecha Nacimiento")]
        [Required(ErrorMessage = "Es nesecario la fecha de nacimiento.")]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage = "Es obligatorio el numero de telefono.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio la dirrecion.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es necesario el Email")]
        public string Email { get; set; }

        public string Sexo { get; set; }

        public string Area { get; set; }
        [DisplayName("Tipo de empleado")]
        public string TipoDeEmp { get; set; }
        [DisplayName("N° Social")]
        [Required(ErrorMessage = "Es necesario el N° Social")]
        public string NumeroSocial { get; set; }
        [DisplayName("N° Bancario")]
        [Required(ErrorMessage = "Es necesario el N° Bancario")]
        public string NumeroBancario { get; set; }
        [DisplayName("Retencion CCSS")]
        public string Ccss { get; set; }
        public string Profesion { get; set; }
        [DisplayName("Fecha Contratacion")]
        [Required(ErrorMessage = "Es obligatorio la fecha de contratacion.")]
        public DateTime FechaContrato { get; set; }

        public string Estado { get; set; }
        public virtual ICollection<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleado { get; set; }
    }
}
