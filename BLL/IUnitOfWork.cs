using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Project { get; }
        ITaskRepository Task { get; }
        Task<int> CommitAsync();
    }
}
