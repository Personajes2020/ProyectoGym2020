using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2
{
    public partial class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [MinLength(5, ErrorMessage = "Minimo de nombre de usuario es 5 caracteres")]
        [Required(ErrorMessage = "Nombre de usuario requerido")]
        public string NombreUsuario { get; set; }
        [MinLength(8, ErrorMessage = "Minimo de contraseña son 8 caracteres")]
        [Required(ErrorMessage = "Contraseña requerida")]
        public string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        public bool Activo { get; set; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        [Compare("Contraseña", ErrorMessage = "Ingrese una contraseña valida, verifique que sean iguales")]
        public string ConfirmarContraseña { get; set; }
        [Required(ErrorMessage = "Ingresar un role es requerido")]

        public int? IdRole { get; set; }
        [DisplayName("Role")]
        public virtual Roles IdRoleNavigation { get; set; }
    }
}

