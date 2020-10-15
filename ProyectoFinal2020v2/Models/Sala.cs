using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Sala
    {
        public Sala()
        {
            ClaseGym = new HashSet<ClaseGym>();
        }

        public int IdSala { get; set; }
        [DisplayName("Nombre Sala")]
        [Required(ErrorMessage ="Se necesita el nombre de la sala")]
        public string NombreSala { get; set; }
        [Required(ErrorMessage ="Se necesita una descricion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Es obligatorio el estado")]
        public string Estado { get; set; }

        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
    }
}
