using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class MatriculaClaseGym
    {
        public int IdMatriculaGym { get; set; }
        public int IdCliente { get; set; }
        public int IdClaseGym { get; set; }
        public DateTime Fecha { get; set; }

        public virtual ClaseGym IdClaseGymNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
