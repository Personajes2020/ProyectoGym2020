using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class Hijo
    {
        public Hijo()
        {
            HijoCliente = new HashSet<HijoCliente>();
        }

        public int IdHijo { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime FechaDeNac { get; set; }

        public virtual ICollection<HijoCliente> HijoCliente { get; set; }
    }
}
