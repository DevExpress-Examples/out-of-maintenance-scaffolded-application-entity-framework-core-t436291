using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Scaffolding.DetailCollectionsEFCore.Model {
    public class DepartmentContext : DbContext {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DetailCollectionsEFCore;Trusted_Connection=True;");
        }

        internal void EnsureSeedData() {
            if(Departments.Any())
                return;

            Department department1 = new Department { Name = "Music" };
            Department department2 = new Department { Name = "Journalism" };
            Department department3 = new Department { Name = "Management" };
            Departments.Add(department1);
            Departments.Add(department2);
            Departments.Add(department3);

            Courses.AddRange(new[] {
                new Course { Title = "First", Department = department1 },
                new Course { Title = "Second", Department = department1 },
                new Course { Title = "Third", Department = department1 },

                new Course { Title = "First", Department = department2 },
                new Course { Title = "Second", Department = department2 },
                new Course { Title = "Third", Department = department2 },

                new Course { Title = "First", Department = department3 },
                new Course { Title = "Second", Department = department3 },
                new Course { Title = "Third", Department = department3 },
            });

            Employees.AddRange(new[] {
                new Employee { Name = "Frankie West PhD", Department = department1 },
                new Employee { Name = "Jett Mitchell", Department = department1 },
                new Employee { Name = "Garrick Stiedemann DVM", Department = department1 },
                new Employee { Name = "Hettie Runte", Department = department1 },
                new Employee { Name = "Gabe Flatley", Department = department2 },
                new Employee { Name = "Zetta Beatty", Department = department2 },
                new Employee { Name = "Ms. Luis Jewess", Department = department2 },
                new Employee { Name = "Jefferey Legros III", Department = department3 },
                new Employee { Name = "Margaretta Roberts", Department = department3 },
            });

            SaveChanges();
        }
    }
}