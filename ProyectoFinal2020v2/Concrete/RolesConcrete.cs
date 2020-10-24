using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal2020v2.Interface;
using ProyectoFinal2020v2.Models;
using System.Text;


namespace ProyectoFinal2020v2.Concrete
{
    public class RolesConcrete : IRoles
    {
        private GymContext _context;

        public RolesConcrete(GymContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Get RoleID Name by RoleName
        /// </summary>
        /// <param name="NombreRole"></param>
        /// <returns></returns>
        public int getRolesofUserbyRolename(string NombreRole)
        {
            var IdRole = (from role in _context.Roles
                          where role.NombreRole == NombreRole
                          select role.IdRole).SingleOrDefault();

            return IdRole;
        }
    }
}

