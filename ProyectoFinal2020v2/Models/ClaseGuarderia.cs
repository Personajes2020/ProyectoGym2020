using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGuarderia
    {
        public ClaseGuarderia()
        {
            ClaseGuarderiaEmpleado = new HashSet<ClaseGuarderiaEmpleado>();
            MatriculaGuarderia = new HashSet<MatriculaGuarderia>();
        }

        public int IdClaseGuarderia { get; set; }
        public string Nombre { get; set; }
        public string IdSala { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Capacidad { get; set; }
        public string Duracion { get; set; }

        public virtual ICollection<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleado { get; set; }
        public virtual ICollection<MatriculaGuarderia> MatriculaGuarderia { get; set; }
    }
}
