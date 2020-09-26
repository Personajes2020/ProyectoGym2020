using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class Sala
    {
        public Sala()
        {
            ClaseGym = new HashSet<ClaseGym>();
        }

        public int IdSala { get; set; }
        public string NombreSala { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
    }
}
