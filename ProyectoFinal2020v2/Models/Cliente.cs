﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal2020v2.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            HijoCliente = new HashSet<HijoCliente>();
            MatriculaClaseGym = new HashSet<MatriculaClaseGym>();
            Monedero = new HashSet<Monedero>();
        }

        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Es obligatorio la identificacion.")]
        public string Identificacion { get; set; }
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; }
        [DisplayName("Primer apellido")]
        [Required(ErrorMessage ="El apellido es requerido")]
        public string Apellido1 { get; set; }
        [DisplayName("Segundo apellido")]
        public string Apellido2 { get; set; }
        [DisplayName("Fecha de nacimiento")]
        [Required(ErrorMessage ="Su fecha de nacimiento es necesaria")]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage ="Su numero de telefono es necesario")]
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es necesario el Email")]
        [RegularExpression("([a-z0-9]+(\\.?[a-z0-9])*)+@(([a-z]+)\\.([a-z]+))",
            ErrorMessage = ("Email Invalido, debe tener una escructura como: ejemplo@ejemplo.com"))]
        public string Email { get; set; }
        public string Estado { get; set; }
        [Required(ErrorMessage ="h si es hombre, m si es mujer")]
        public string Sexo { get; set; }
        public string Casillero { get; set; }
        [Required(ErrorMessage ="La tarifa es obligatoria.")]
        [DisplayName("Tarifa")]
        public string IdTarifa { get; set; }

        public virtual ICollection<HijoCliente> HijoCliente { get; set; }
        public virtual ICollection<MatriculaClaseGym> MatriculaClaseGym { get; set; }
        public virtual ICollection<Monedero> Monedero { get; set; }
    }
}
