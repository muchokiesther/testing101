using project_management.Data;
using project_management.Models;
using project_management.Services.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management.Services
{
    public class AdminServices : IAdminInterface
    {
        private readonly ApplicationDbContext _context;

   

        public AdminServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<project>> GetAllProjects()
        {
            var projects = await _context.project.ToListAsync();

            if (projects != null && projects.Count > 0)
            {
                return projects;
            }

            throw new Exception("No projects found.");
        }

        public async Task<List<tasks>> GetAlltasks()
        {
            var tasks = await _context.tasks.ToListAsync();

            if (tasks != null && tasks.Count > 0)
            {
                return tasks;
            }

            throw new Exception("No tasks found.");
        }

        public async Task<List<tasks>> GetAlltasks(int TaskId)
        {
            var tasks = await _context.tasks.Where(t => t.TaskId == TaskId).ToListAsync();

            if (tasks != null && tasks.Count > 0)
            {
                return tasks;
            }

            throw new Exception($"No tasks found for TaskId {TaskId}.");
        }

        public Task<List<tasks>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public async Task<List<project>> GetOneProjects(int ProjectId)
        {
            var projects = await _context.project.Where(p => p.ProjectId == ProjectId).ToListAsync();

            if (projects != null && projects.Count > 0)
            {
                return projects;
            }

            throw new Exception($"No project found for ProjectId {ProjectId}.");
        }

        public async Task<List<tasks>> GetOneTaskById(int TaskId)
        {
            var task = await _context.tasks.FirstOrDefaultAsync(t => t.TaskId == TaskId);

            if (task != null)
            {
                return new List<tasks> { task };
            }

            throw new Exception($"No task found for TaskId {TaskId}.");
        }

    }
}
