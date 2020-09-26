using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class MatriculaGuarderia
    {
        public int IdMatricula { get; set; }
        public int IdClaseGuarderia { get; set; }
        public int IdHijo { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ClaseGuarderia IdClaseGuarderiaNavigation { get; set; }
    }
}
