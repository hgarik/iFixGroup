using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IProjectService
    {
        Task<Project> CreateProject(Project project);
        Task EditProject(Project project);
        Task DeleteProject(Project project);
        IEnumerable<string> GetById(int id);
    }
}
