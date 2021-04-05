using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface IRoleService
    {
        Task<Role> SingleRole(int id);
        Task<bool> EditRole(int id, Role role);
    }
}
