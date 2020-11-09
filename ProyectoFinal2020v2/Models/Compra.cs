using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
  
    public class Compra
    {
        public Compra()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
        }
        [Key]
        public int IdCompra { get; set; }
        [DisplayName("Id Cliente")]
        [Required(ErrorMessage ="Es obligatorio el cliente")]
        public int IdCliente { get; set; }
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }/* =DateTime.Now;*/
        [Required(ErrorMessage = "Importe")]
        public int Importe { get; set; }
        [DisplayName("Id Empleado")]
        [Required(ErrorMessage = "Es obligatorio el empleado")]
        public int IdEmpleado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }

    }
}
