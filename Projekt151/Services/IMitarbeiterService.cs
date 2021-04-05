using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface IMitarbeiterService
    {
        Task<IEnumerable<MitarbeiterModel>> GetEmployees();
        Task<bool> CreateEmployee(Mitarbeiter mitarbeiter);
        Task<bool> EditEmployee(int id, MitarbeiterModel mitarbeiter);
        Task<MitarbeiterModel> SingleEmployee(int id);
        Task<bool> DeleteEmployee(int id);
    }
}
