using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task3.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace Task3.Services
{
    public class Linq
    {
        private readonly ApplicationContext _context;
        public Linq(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Task3()
        {
            Console.WriteLine("----------Task3--------------");
            var office = await _context.Offices.FirstOrDefaultAsync(o => o.Id == 11);
            var title = await _context.Titles.FirstOrDefaultAsync(t => t.TitleId == 11);
            Console.WriteLine($"Current Office - {office.Title} Current Title - {title.Name}");
            office.Title = "NewTestOffice";
            title.Name = "NewJunior";
            await _context.SaveChangesAsync();
            var newoffice = await _context.Offices.FirstOrDefaultAsync(o => o.Id == 11);
            var newtitle = await _context.Titles.FirstOrDefaultAsync(t => t.TitleId == 11);
            Console.WriteLine($"NewCurrent Office - {newoffice.Title} NewCurrent Title - {newtitle.Name}");
        }

        public async Task Task4()
        {
            Console.WriteLine("----------Task4--------------");
            var office = await _context.Offices.FirstAsync(o => o.Id == 11);
            var project = await _context.Projects.FirstAsync(t => t.Id == 11);
            var newempoyeer = new Employee
            {
                FirstName = "John",
                LastName = "Cena",
                DateofBirth = new DateTime(1999, 12, 21),
                HiredDate = new DateTime(2020, 01, 5),
                OfficeId = office.Id,
                Title = new Title() { Name = "Restrler" },
                EmployeeProjects = new List<EmployeeProject>() { new EmployeeProject() { Rate = 6, ProjectId = project.Id, StartedDate = new DateTime(2019, 12, 17) } }
            };
            await _context.Employees.AddAsync(newempoyeer);
            await _context.SaveChangesAsync();
        }

        public async Task Task5()
        {
            Console.WriteLine("----------Task5--------------");
            var emp = await _context.Employees.FirstAsync(o => o.Id == 15);
            _context.EmployeesProjects.RemoveRange(emp.EmployeeProjects);
            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
        }

        public async Task Task6()
        {
            Console.WriteLine("----------Task6--------------");
            var emp = await _context.Employees
                .GroupBy(g => g.Title.Name)
                .Where(w => !w.Key.Contains("a"))
                .Select(s => s.Key)
                .ToListAsync();
            foreach (var item in emp)
            {
                Console.WriteLine($"Employe without a - {item}");
            }
        }

        public async Task Task2()
        {
            Console.WriteLine("----------Task2--------------");
            var difdate = await _context.Projects
                .Select(s => new
                {
                    differents = EF.Functions.DateDiffDay(s.StartedDate, DateTime.Now)
                })
                .ToListAsync();
            foreach (var item in difdate)
            {
                Console.WriteLine($"Difference in date - {item.differents}");
            }
        }

        public async Task Task1()
        {
            Console.WriteLine("----------Task1--------------");
            var result = await (
                from office in _context.Offices
                join emp in _context.Employees
                on office.Id equals emp.OfficeId into officeemp
                from empandoffice in officeemp.DefaultIfEmpty()
                join title in _context.Titles
                on empandoffice.TitleId equals title.TitleId into newemployy
                from newjoin in newemployy.DefaultIfEmpty()
                select new
                {
                    Name = empandoffice.FirstName,
                    OfficeName = office.Title
                }).ToListAsync();
            foreach (var item in result)
            {
                Console.WriteLine($"NameofEmployyer - {item.Name} and OfficeName - {item.OfficeName} ");
            }
        }
    }
}
