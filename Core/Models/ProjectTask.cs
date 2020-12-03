using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public int Owner { get; set; }
        public string Name { get; set; }


    }
}
