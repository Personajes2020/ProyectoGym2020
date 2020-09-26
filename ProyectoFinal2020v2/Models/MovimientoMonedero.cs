using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class MovimientoMonedero
    {
        public int IdMonedero { get; set; }
        public int IdTipoMovimiento { get; set; }
        public double Monto { get; set; }

        public virtual Monedero IdMonederoNavigation { get; set; }
        public virtual TipoMovimiento IdTipoMovimientoNavigation { get; set; }
    }
}
