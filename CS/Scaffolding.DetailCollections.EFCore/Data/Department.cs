using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Scaffolding.DetailCollectionsEFCore.Model {
    public class Department {
        public Department() {
            Courses = new HashSet<Course>();
            Employees = new HashSet<Employee>();
        }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}