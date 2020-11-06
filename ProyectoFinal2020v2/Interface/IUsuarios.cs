using ProyectoFinal2020v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal2020v2.Interface
{
    public interface IUsuarios
    {
        int AddUser(Usuarios entity);
        void AddAdmin(Usuarios entity);
        bool CheckUserNameExists(string NombreUsuario);
        UsuariosViewModel Userinformation(int IdUsuario);
        IQueryable<UsuariosViewModel> UserinformationList(string sortColumn, string sortColumnDir, string Search);

    }
}