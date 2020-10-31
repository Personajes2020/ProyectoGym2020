using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class MatriculaGuarderia
    {
        public int IdMatricula { get; set; }
        [DisplayName("Id Clase")]
        [Required(ErrorMessage ="Se necesita ingrear la clase")]
        public int IdClaseGuarderia { get; set; }
        [DisplayName("Hijo")]
        [Required(ErrorMessage = "Es obligatorio ingresar  el hijo")]
        public int IdHijo { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ClaseGuarderia IdClaseGuarderiaNavigation { get; set; }
        public virtual Hijo IdHijoNavigation { get; set; }
    }
}
