using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Scaffolding.DetailCollectionsEFCore.Model {
    public class Course {
        public int CourseID { get; set; }
        [Required]
        public string Title { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}