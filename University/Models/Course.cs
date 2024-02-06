using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}