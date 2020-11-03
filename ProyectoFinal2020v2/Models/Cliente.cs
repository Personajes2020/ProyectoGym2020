using System;
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
            //Casillero = new HashSet<Casillero>();
            //Tarifa = new HashSet<Tarifa>();
            
        }

        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Es obligatorio la identificacion.")]
        public string Identificacion { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [DisplayName("1er apellido")]
        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido1 { get; set; }
        [DisplayName("2do apellido")]
        public string Apellido2 { get; set; }
        [DisplayName("Nació el?")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de nacimiento es necesaria")]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage = "Su numero de telefono es necesario")]
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Es necesario el Email")]
        [RegularExpression("([a-z0-9]+(\\.?[a-z0-9])*)+@(([a-z]+)\\.([a-z]+))",
            ErrorMessage = ("Email Invalido, debe tener una escructura como: ejemplo@ejemplo.com"))]
        public string Email { get; set; }
        public string Estado { get; set; }   
        [Required(ErrorMessage ="Obligatorio")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "La casillero es obligatoria.")]
        [DisplayName("Casillero")]
        public int? IdCasillero { get; set; }
        [Required(ErrorMessage = "La tarifa es obligatoria.")]
        [DisplayName("Tarifa")]
        public int IdTarifa { get; set; } 
        
        [DisplayName("Casillero")]
        public virtual Casillero IdCasilleroNavigation { get; set; }    
        [DisplayName("Tarifa")]
        public virtual Tarifa IdTarifaNavigation { get; set; }
        public virtual ICollection<HijoCliente> HijoCliente { get; set; }
        public virtual ICollection<MatriculaClaseGym> MatriculaClaseGym { get; set; }
        public virtual ICollection<Monedero> Monedero { get; set; }
    }
}
