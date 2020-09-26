using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class HijoCliente
    {
        public int IdHijoCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdHijo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Hijo IdHijoNavigation { get; set; }
    }
}
