using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGuarderia
    {
        public ClaseGuarderia()
        {
            ClaseGuarderiaEmpleado = new HashSet<ClaseGuarderiaEmpleado>();
            MatriculaGuarderia = new HashSet<MatriculaGuarderia>();
        }

        public int IdClaseGuarderia { get; set; }
        [DisplayName("Hora Inicio")]
        [Required(ErrorMessage ="Se necesita hora inicio")]
        public string HoraInicio { get; set; }
        [DisplayName("Hora Final")]
        [Required(ErrorMessage = "Se necesita hora final")]
        public string HoraFin { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Se requiere la fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Se requiere la cantidad max")]
        public int Cupo { get; set; }
        [DisplayName("Duracion(Horas)")]
        //[Required(ErrorMessage = "Se requiere la duracion")]
        public int? Duracion { get; set; }
        [Required(ErrorMessage = "Es obligatorio el estado")]
        public string Estado { get; set; }
    
    public virtual ICollection<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleado { get; set; }
        public virtual ICollection<MatriculaGuarderia> MatriculaGuarderia { get; set; }
    }
}
