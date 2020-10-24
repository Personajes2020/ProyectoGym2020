using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal2020v2.Models;
using System.Text;

namespace ProyectoFinal2020v2.Interface
{
    public interface ILogin
    {
        Usuarios ValidateUser(string nombreUsuario, string contraSeña);
        bool UpdatePassword(Usuarios Usuarios);
    }
}
