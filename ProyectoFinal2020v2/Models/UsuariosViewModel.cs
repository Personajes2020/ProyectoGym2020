using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProyectoFinal2020v2.Models
{
    [NotMapped]
    public class UsuariosViewModel
    {

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        public string ConfirmarContraseña { get; set; }
        public int? IdRole { get; set; }
    }
}

