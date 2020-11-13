using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Fecha Compra")]
        public DateTime FechaCompra { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Fecha Llegada")]
        public DateTime FechaLlegada { get; set; }
        public string Estado { get; set; }
        public double Importe { get; set; }
        [DisplayName("Justificacion")]
        public string Descripcion { get; set; }

        public virtual ICollection<DetallesPedido> DetallesPedido { get; set; }
    }
}
