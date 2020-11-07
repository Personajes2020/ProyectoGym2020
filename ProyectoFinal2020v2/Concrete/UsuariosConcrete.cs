using ProyectoFinal2020v2.Interface;
using ProyectoFinal2020v2.Models;
using System.Collections.Generic;
using System.Linq;
//using System.Linq.Dynamic;

namespace ProyectoFinal2020v2.Concrete
{
    public class UsuariosConcrete : IUsuarios
    {
        private GymContext _context;

        public UsuariosConcrete(GymContext context)
        {
            _context = context;
        }

        public void AddAdmin(Usuarios entity)
        {
            _context.Usuarios.Add(entity);
            _context.SaveChanges();
        }

        public int AddUser(Usuarios entity)
        {
            _context.Usuarios.Add(entity);
            return _context.SaveChanges();
        }

        public bool CheckUserNameExists(string NombreUsuario)
        {
            var result = (from user in _context.Usuarios
                          where user.NombreUsuario == NombreUsuario
                          select user).Count();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UsuariosViewModel Userinformation(int IdUsuario)
        {
            var result = (from user in _context.Usuarios
                          
                          where user.IdUsuario == IdUsuario
                          select new UsuariosViewModel
                          {
                             
                              
                              FechaCreacion = user.FechaCreacion,
                              Activo=user.Activo,
                              NombreUsuario = user.NombreUsuario,
                              Contraseña = user.Contraseña,
                          }).SingleOrDefault();
            return result;
        }

        public IQueryable<UsuariosViewModel> UserinformationList(string sortColumn, string sortColumnDir, string Search)
        {
            var IQueryableReg = (from user in _context.Usuarios
                                
                                 select new UsuariosViewModel
                                 {
                                     //CountryName = country.Name,
                                     //StateName = states.StateName,
                                     //CityName = city.CityName,
                                     //Name = user.Name,
                                     //Address = user.Address,
                                     //EmailID = user.EmailID,
                                     //CreatedOn = user.CreatedOn.Value.ToString("dd/MM/yyyy"),
                                     //Birthdate = user.Birthdate.Value.ToString("dd/MM/yyyy"),
                                     //Gender = user.Gender == "M" ? "Male" : "Female",
                                     //Mobileno = user.Mobileno,
                                     NombreUsuario = user.NombreUsuario
                                 });
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
            {
                //IQueryableReg = IQueryableReg.OrderBy(sortColumn + " " + sortColumnDir);
            }
            if (!string.IsNullOrEmpty(Search))
            {
                IQueryableReg = IQueryableReg.Where(m => m.NombreUsuario == Search );
            }

            return IQueryableReg;
        }
    }
}
