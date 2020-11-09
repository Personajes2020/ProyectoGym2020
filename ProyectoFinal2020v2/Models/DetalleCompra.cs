using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public partial class DetalleCompra
    {
        [Key]
        public int IdDetalleCompra { get; set; }

        public int IdCompra { get; set; }
        [DisplayName("Id Producto")]
        [Required(ErrorMessage = "Es necesario el id Producto")]
        public int IdProducto { get; set; }
        [DisplayName("Precio Unidad")]
        
        public double PrecioUnidad { get; set; }
        public int Cantidad { get; set; }
        public double? Descuento { get; set; }

        public virtual Compra IdCompraNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
