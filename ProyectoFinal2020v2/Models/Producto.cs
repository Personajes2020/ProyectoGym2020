using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }
        public string Existencia { get; set; }
        public DateTime FechaCadu { get; set; }
        public int IdCategoria { get; set; }
        public string PrecioUnidad { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
