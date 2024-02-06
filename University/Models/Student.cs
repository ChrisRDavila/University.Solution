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
    public List<CourseStudent> JoinEntities { get;}
  }
}