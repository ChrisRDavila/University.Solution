using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace University.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "The student's name can't be empty!")]
    public string StudentName { get; set; }
    [Required(ErrorMessage = "The student's enrollment date can't be empty!")]
    public DateTime Enrollment { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your student to a department. Have you created the correct/any department yet?")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public List<CourseStudent> JoinEntities { get;}
  }
}