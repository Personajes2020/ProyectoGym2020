﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Actividad
    {
        public Actividad()
        {
            ClaseGym = new HashSet<ClaseGym>();
        }

        public int IdActividad { get; set; }
        [Required(ErrorMessage = "Es obligatorio el Nombre de actividad.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es obligatorio la Descripcion.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Es obligatorio la Duracion en horas")]
        [DisplayName("Duración(Horas)")]
        public int Duracion { get; set; }
        [Required(ErrorMessage = "Es obligatorio el estado")]
        public string Estado { get; set; }
        public virtual ICollection<ClaseGym> ClaseGym { get; set; }
    }
}
