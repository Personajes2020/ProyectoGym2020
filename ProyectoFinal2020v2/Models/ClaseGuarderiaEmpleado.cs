using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGuarderiaEmpleado
    {
        public int IdClaseGuarderiaEmpleado { get; set; }
        public int IdClaseGuarderia { get; set; }
        public int IdEmpleado { get; set; }

        public virtual ClaseGuarderia IdClaseGuarderiaNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
