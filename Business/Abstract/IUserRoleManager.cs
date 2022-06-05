using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Models;
using DataAccess.Concrete.EntityFramework;
using Entitties.DTOs;

namespace Business.Abstract
{
    public interface IUserRoleManager
    {
        void AddUserRole(AddUserRoleDTO userrole);
        List<UserRoleDTO> GetAllUserRoles();
        UserRoleDTO GetUserRoleById(int id);
    }
}
