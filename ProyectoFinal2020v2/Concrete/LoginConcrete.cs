using ProyectoFinal2020v2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProyectoFinal2020v2.Models;


namespace ProyectoFinal2020v2.Concrete
{
    public class LoginConcrete : ILogin
    {
        private GymContext _context;

        public LoginConcrete(GymContext context)
        {
            _context = context;
        }

        public Usuarios ValidateUser(string nombreUsuario, string contraSeña)
        {
            try
            {
                var validate = (from user in _context.Usuarios
                                where user.NombreUsuario == nombreUsuario && user.Contraseña == contraSeña
                                select user).SingleOrDefault();

                return validate;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdatePassword(Usuarios Usuarios)
        {
            _context.Usuarios.Attach(Usuarios);
            _context.Entry(Usuarios).Property(x => x.Contraseña).IsModified = true;
            int result = _context.SaveChanges();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
