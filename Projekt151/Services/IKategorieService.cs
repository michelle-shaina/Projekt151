using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface IKategorieService
    {
        Task<IEnumerable<Kategorie>> GetCategories();
        Task<bool> CreateCategory(Kategorie kategorie);
        Task<bool> EditCategory(int id, Kategorie kategorie);
        Task<Kategorie> SingleCategory(int id);
        Task<bool> DeleteCategory(int id);
    }
}
