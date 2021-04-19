using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime DateofBirth { get; set; }
        public int OfficeId { get; set; }
        public Title Title { get; set; }
        public int TitleId { get; set; }
        public Office Office { get; set; }
        public List<EmployeeProject> Users { get; set; } = new List<EmployeeProject>();
    }
}
