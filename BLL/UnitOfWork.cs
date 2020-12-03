using Core;
using Core.Repositories;
using DAL.Data;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IFixGroupDbContext _context;

        private IProjectRepository _projectRepository;
        private ITaskRepository _taskRepository;

        public UnitOfWork(IFixGroupDbContext context)
        {
            this._context = context;
        }
        public IProjectRepository Project => _projectRepository = _projectRepository ?? new ProjectRepository(_context);
        public ITaskRepository Task => _taskRepository = _taskRepository ?? new TaskRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
