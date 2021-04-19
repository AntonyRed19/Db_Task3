using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }

        public List<Employee> Users { get; set; } = new List<Employee>();
    }
}
