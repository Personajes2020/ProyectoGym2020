using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Monedero
    {
        public Monedero()
        {
            RecargaMonederoV = new HashSet<RecargaMonederoV>();
        }
        public int IdMonedero { get; set; }
        [DisplayName("Cliente")]
        [Required(ErrorMessage = "El cliente es requerido")]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "El salo es requerido")]
        public double Saldo { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        
        public virtual ICollection<RecargaMonederoV> RecargaMonederoV { get; set; }
    }
}
