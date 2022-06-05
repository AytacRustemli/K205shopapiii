using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Entity.Models;
using Entitties.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserRoleDal : IEntityRepository<UserRole>
    {
        List<UserRoleDTO> GetAllUserRole();
        UserRoleDTO GetUserRole(int id);
    }
}
