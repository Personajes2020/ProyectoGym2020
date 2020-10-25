using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class ClaseGym
    {
        public ClaseGym()
        {
            MatriculaClaseGym = new HashSet<MatriculaClaseGym>();
        }

        public int IdClaseGym { get; set; }
        [DisplayName("Sala")]
        [Required(ErrorMessage ="Se necesita el nombre de la sala")]
        public int IdSala { get; set; }
        [Required(ErrorMessage = "Se necesita la hora de inicio")]
        //[DataType(DataType.Time)]
        public string HoraInicio { get; set; }
        [Required(ErrorMessage = "Se necesita la hora de final")]
        //[DataType(DataType.Time)]
        public string HoraFinal { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Se necesita la fecha de la clase")]
        public DateTime Fecha { get; set; }
        public int Cupo { get; set; }
        [DisplayName("Actividad")]
        [Required(ErrorMessage = "Se requiere actividad")]
        public int IdActividad { get; set; }
        [DisplayName("Empleado")]
        [Required(ErrorMessage = "Es necesario el empleado")]
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "Es obligatorio el estado")]
        public string Estado { get; set; }
        public virtual Actividad IdActividadNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
        public virtual ICollection<MatriculaClaseGym> MatriculaClaseGym { get; set; }
    }
}
