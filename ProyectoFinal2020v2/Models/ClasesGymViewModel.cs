using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class ClasesGymViewModel
    {
        public int IdClaseGym { get; set; }
        public int IdSala { get; set; }
        public string NSala { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public DateTime Fecha { get; set; }
        public int Cupo { get; set; }
        public int IdActividad { get; set; }
        public string NActividad { get; set; }
        public int IdEmpleado { get; set; }
        public string NEmpleado { get; set; }
        public string Estado { get; set; }
    }
}
