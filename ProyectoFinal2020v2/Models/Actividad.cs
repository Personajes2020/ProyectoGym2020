using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            ClaseGym = new HashSet<ClaseGym>();
        }

        public int IdActividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }

        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
    }
}
