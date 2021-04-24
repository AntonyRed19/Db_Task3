using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Task3.Entities;
using Task3.EntityConfigurations;

namespace Task3
{
    public class Starter
    {
        public void Run()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            using (var db = new ApplicationContext(options))
            {
                var employee = db.Employees.ToList();
                var employeesproject = db.EmployeesProjects.ToList();
                var office = db.Offices.ToList();
                var project = db.Projects.ToList();
                var title = db.Titles.ToList();

                db.SaveChanges();
            }

            Console.Read();
        }
    }
}
