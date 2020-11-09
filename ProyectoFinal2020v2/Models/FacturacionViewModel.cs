using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class FacturacionViewModel
    {
        public Compra Compra { get; set; }
        public List<DetalleCompra>DetalleCompra { get; set; }
       
    }
}
