using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    [Required(ErrorMessage = "The department's name can't be empty!")]
    public string DepartmentName { get; set; }
    [Required(ErrorMessage = "We suggest creating a description for each department!")]
    public string Description { get; set; }
    public List<Course> Courses { get; set; }
    public List<Student> Students { get; set; }
  }
}

//possibly create two different PK for department? on for AI with student and one with AI with course?
//Recieving a message that departments table already exists