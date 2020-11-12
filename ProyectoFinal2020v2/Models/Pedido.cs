using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallesPedido = new HashSet<DetallesPedido>();
        }

        public int IdPedido { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaCompra { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaLlegada { get; set; }
        public string Estado { get; set; }
        public double Importe { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<DetallesPedido> DetallesPedido { get; set; }
    }
}
