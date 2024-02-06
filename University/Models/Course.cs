using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    [Required(ErrorMessage = "The course name can't be empty!")]
    public string CourseName { get; set; }
    [Required(ErrorMessage = "The course code can't be empty!")]
    public string CourseCode { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your course to a department. Have you created the correct/any department yet?")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}