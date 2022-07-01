using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity.Models;
using Entitties.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IAuthManager
    {
        void Register(RegisterDTO model);
        K205User GetUserByEmail(string email);
        K205User Login(string email);
        List<K205User> GetUsers();
       
    }
}
