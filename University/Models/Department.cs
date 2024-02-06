using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "The department's name can't be empty!")]
    public string DepartmentName { get; set; }
    [Required(ErrorMessage = "We suggest creating a descrption for each department!")]
    public string Description { get; set; }
    public List<Course> Courses { get; set; }
  }
}