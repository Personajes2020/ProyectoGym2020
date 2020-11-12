using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class DetallesPedido
    {
        public int IdDetalles { get; set; }
        [DisplayName("#Pedido")]
        public int IdPedido { get; set; }
        [DisplayName("Producto")]
        public int IdProducto { get; set; }
        [DisplayName("Categoria")]
        public int? IdCategoria { get; set; }
        [DisplayName("Proveedor")]
        public int? IdProveedor { get; set; }
        [DisplayName("Precio")]
        public double PrecioUnidad { get; set; }
        [DisplayName("Unidades")]
        public int UnidadesSolicitadas { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Vencimiento")]
        public DateTime FechaCaducidad { get; set; }
        [DisplayName("Categoria")]
        public virtual Categoria IdCategoriaNavigation { get; set; }
        [DisplayName("#Pedido")]
        public virtual Pedido IdPedidoNavigation { get; set; }
        [DisplayName("Producto")]
        public virtual Producto IdProductoNavigation { get; set; }
        [DisplayName("Proveedor")]
        public virtual Proveedor IdProveedorNavigation { get; set; }
        
    }
}
