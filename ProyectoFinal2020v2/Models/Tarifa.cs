using System;
using System.Collections.Generic;

namespace ProyectoFinal2020v2.Models
{
    public partial class Tarifa
    {
        public string IdTarifa { get; set; }
        public double PrecioTarifa { get; set; }
        public int? Bebes { get; set; }
        public string Duracion { get; set; }
        public string Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
