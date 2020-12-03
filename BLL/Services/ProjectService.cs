using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IUnitOfWork unitOfWork)
        { 
            this._unitOfWork = unitOfWork;
        }
        public async Task<Project> CreateProject(Project project)
        {
            await _unitOfWork.Project.AddAsync(project);
            await _unitOfWork.CommitAsync();
            return project;
        }

        public async Task EditProject(Project project)
        {
            var projectToEdit = await _unitOfWork.Project.GetByIdAsync(project.Id);
            //projectToEdit. = project
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteProject(Project project)
        {
            await _unitOfWork.Project.RemoveAsync(project);
            await _unitOfWork.CommitAsync();
        }

        public IEnumerable<string> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
