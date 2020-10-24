using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2
{
    public partial class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [MinLength(5, ErrorMessage = "Minimo de nombre de usuario es 5 caracteres")]
        [Required(ErrorMessage = "Nombre de usuario requeridoo")]
        public string NombreUsuario { get; set; }
        [MinLength(8, ErrorMessage = "Minimo de contraseña son 8 caracteres")]
        [Required(ErrorMessage = "Contraseña requerida")]
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }
        [Required(ErrorMessage = "Confrimar la contraseña es requerida")]
        [Compare("Contraseña", ErrorMessage = "Ingrese una contraseña valida")]
        public string ConfirmarContraseña { get; set; }

        public int? IdRole { get; set; }

        //public virtual Roles IdRoleNavigation { get; set; }
    }
}
