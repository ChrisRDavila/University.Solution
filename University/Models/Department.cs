using System.Collections.Generic;

namespace University.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string Description { get; set; }
    public List<Course> Courses { get; set; }
  }
}