using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface IProjektService
    {
        Task<IEnumerable<ProjectFormatted>> GetP();
        Task<bool> CreateProjects(ProjectFormatted projekt);
        Task<bool> EditProject(int id, ProjectFormatted projekt);
        Task<ProjectFormatted> SingleProject(int id);
        Task<bool> DelteProject(int id);
    }
}
