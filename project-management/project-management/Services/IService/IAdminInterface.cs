using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_management.Models;

namespace project_management.Services.IService
{
    internal interface IAdminInterface
    {
        Task<List<project>> GetAllProjects();
        Task<List<project>> GetOneProjects(int ProjectId);
        Task<List<tasks>> GetAllTasks();
        Task<List<tasks>> GetOneTaskById(int TaskId);

    }
}
