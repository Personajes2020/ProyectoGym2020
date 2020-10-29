using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Models
{
    public class MatriculaGymViewModel
    {
        public int IdMatriculaGym { get; set; }
        public int IdClase { get; set; }
        public string Clase { get; set; }
        public string IdCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
    }
}
