using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProyectoFinal2020v2.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
            Pedido = new HashSet<Pedido>();
        }
        
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "Es obligatorio el codigo del producto.")]
        public string Codigo { get; set; }
       
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Es obligatorio el nombre.")]
        public string Nombre { get; set; }
        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "Es obligatorio la descripcion.")]
        public string Descripcion { get; set; }
        [DisplayName("Id Proveedor")]
        [Required(ErrorMessage = "Es obligatorio el id de Proveedor")]
        public int IdProveedor { get; set; }
        [DisplayName("Existencia")]
        [Required(ErrorMessage = "Es obligatorio una cantidad")]
        public int Existencia { get; set; }
        [DisplayName("Fecha de Vencimiento")]
        [Required(ErrorMessage = "Es necesario la fecha de caducidad.")]
        [DataType(DataType.Date)]
        public DateTime FechaCadu { get; set; }

        [DisplayName("Id Categoria")]
        [Required(ErrorMessage = "Es necesario el id de categoria")]
        public int IdCategoria { get; set; }
        [DisplayName("Precio unidad")]
        [Required(ErrorMessage = "Es necesario el precio del producto")]
        public double PrecioUnidad { get; set; }

        [DisplayName("Categoria")]
        public virtual Categoria IdCategoriaNavigation { get; set; }
        [DisplayName("Proveedor")]
        public virtual Proveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
    }
}
