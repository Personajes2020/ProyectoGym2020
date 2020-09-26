using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGym
    {
        public ClaseGym()
        {
            MatriculaClaseGym = new HashSet<MatriculaClaseGym>();
        }

        public int IdClaseGym { get; set; }
        public int IdSala { get; set; }
        public TimeSpan Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int Cupo { get; set; }
        public int IdActividad { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Actividad IdActividadNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
        public virtual ICollection<MatriculaClaseGym> MatriculaClaseGym { get; set; }
    }
}
