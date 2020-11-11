using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class ClaseGuarderiaListarViewModel
    {
        public int IdClaseGuarderia { get; set; }
       
        public string HoraInicio { get; set; }
        
        public string HoraFin { get; set; }
       
        public DateTime Fecha { get; set; }
        
        public int Cupo { get; set; }
         
        public string Estado { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public List<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleados { get; set; }
    }
}
