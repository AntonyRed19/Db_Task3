using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Badget { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> Users { get; set; } = new List<EmployeeProject>();
    }
}
