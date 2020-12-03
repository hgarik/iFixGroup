using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    class ProjectManager : User
    {
        public List<User> Team { get; set; }
        public List<Project> Project { get; set; }
        public int MyProperty { get; set; }
    }
}
