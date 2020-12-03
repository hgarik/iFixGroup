using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    class Team
    {
        public ProjectManager Manager { get; set; }
        public List<Developer> Developers { get; set; }
    }
}
