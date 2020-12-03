using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IProjectTaskService
    {
        Task<ProjectTask> Create(ProjectTask task);
        Task Edit(ProjectTask projectTask);
        Task Delete(ProjectTask task);

    }
}
