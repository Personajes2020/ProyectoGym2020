using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal2020v2.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            DetallesPedido = new HashSet<DetallesPedido>();
            Producto = new HashSet<Producto>();
        }
       // [Required(ErrorMessage = "Es obligatorio la identificacion.")]
        public int IdProveedor { get; set; }
        [Required(ErrorMessage = "Es obligatorio una identificacion.")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "Es obligatorio un nombre.")]
        public string NombreProducto { get; set; }
        
        [Required(ErrorMessage = "La descripcion es obligatorio.")]
        public string Descripcion { get; set; }
      
        [Required(ErrorMessage = "El nombre del representate es  obligatorio.")]
        public string NombreRepresentante { get; set; }
        
        [Required(ErrorMessage = "La telefono es obligatorio.")]
        public string Telefono { get; set; }
       
        [Required(ErrorMessage = "Es necesario el Email")]
        [RegularExpression("([a-z0-9]+(\\.?[a-z0-9])*)+@(([a-z]+)\\.([a-z]+))",
        ErrorMessage = ("Email Invalido, debe tener una escructura como: ejemplo@ejemplo.com"))]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un estado.")]
        public string Estado { get; set; }

        public virtual ICollection<DetallesPedido> DetallesPedido { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
