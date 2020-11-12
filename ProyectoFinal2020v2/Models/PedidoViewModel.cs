using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class PedidoViewModel
    {
        public float Total { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaLLegada { get; set; }
        public string Estado { get; set; }       
        public List<DetallesPedido> detalles { get; set; }
    }
}
