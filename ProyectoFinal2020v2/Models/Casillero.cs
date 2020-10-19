using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Casillero
    {
        public Casillero()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdCasillero { get; set; }
        [Required(ErrorMessage = "Es necesaria la Descripcion")]
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}
