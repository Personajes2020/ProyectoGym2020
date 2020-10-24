using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal2020v2.Models
{
    [NotMapped]
    public class LoginViewModel
    {

        [Required(ErrorMessage = "El Nombre de Usuario es requerida")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La Contraseña es requerida")]
        public string Contraseña { get; set; }

    }
}
