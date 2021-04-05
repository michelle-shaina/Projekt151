using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface IStadtService
    {
        Task<IEnumerable<Stadt>> GetCities();
        Task<bool> CreateCities(Stadt stadt);
        Task<bool> EditCity(int id, Stadt stadt);
        Task<Stadt> SingleCity(int id);
        Task<bool> DeleteCity(int id);
    }
}
