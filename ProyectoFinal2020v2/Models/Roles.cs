using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRole { get; set; }
        public string NombreRole { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}

