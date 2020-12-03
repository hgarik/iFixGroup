using Core.Models;
using Core.Repositories;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(IFixGroupDbContext context)
            : base(context)
        { }
        public async Task<IEnumerable<Project>> GetAllWithTasksAsync()
        {
            return await IFixGroupDbContext.Project
                .Include(m => m.Tasks)
                .ToListAsync();
        }
        private IFixGroupDbContext IFixGroupDbContext
        {
            get { return Context as IFixGroupDbContext; }
        }
    }
}