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
    [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public DateTime Enrollment { get; set; }
    public List<CourseStudent> JoinEntities { get;}
  }
}