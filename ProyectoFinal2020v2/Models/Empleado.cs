﻿using System;
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
            Compra = new HashSet<Compra>();
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
        [DataType(DataType.Date)]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage = "Es obligatorio el numero de telefono.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Es obligatorio la dirrecion.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es necesario el Email")]
        [RegularExpression("([a-z0-9]+(\\.?[a-z0-9])*)+@(([a-z]+)\\.([a-z]+))",
            ErrorMessage = ("Email Invalido, debe tener una escructura como: ejemplo@ejemplo.com"))]
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
        [DataType(DataType.Date)]
        [DisplayName("Fecha Contratacion")]
        [Required(ErrorMessage = "Es obligatorio la fecha de contratacion.")]
        public DateTime FechaContrato { get; set; }

        public string Estado { get; set; }
        public virtual ICollection<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleado { get; set; }
        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
