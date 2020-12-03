using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public List<ProjectTask> Tasks { get; set; }

    }
}
