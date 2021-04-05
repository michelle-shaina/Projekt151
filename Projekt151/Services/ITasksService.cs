using Projekt151.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt151.Services
{
    public interface ITasksService
    {
        Task<IEnumerable<Tasks>> GetTasks();
        Task<bool> CreateTask(Tasks task);
        Task<bool> EditTask(int id, Tasks task);
        Task<Tasks> SingeleTask(int id);
        Task<bool> DeleteTask(int id);
    }
}
