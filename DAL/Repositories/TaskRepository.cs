using Core.Models;
using Core.Repositories;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class TaskRepository : Repository<ProjectTask>, ITaskRepository
    {
        public TaskRepository(IFixGroupDbContext context)
            : base(context)
        { }
        private IFixGroupDbContext IFixGroupDbContext
        {
            get { return Context as IFixGroupDbContext; }
        }
    }

}