using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdMonedero { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Monto { get; set; }

        public virtual Monedero IdMonederoNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }

    }
}
