using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;

namespace University.Controllers
{
    public class HomeController : Controller
    {
      private readonly UniversityContext _db;

      public HomeController(UniversityContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
    public ActionResult Index()
    {
      Course[] crs = _db.Courses.ToArray();
      Student[] stud = _db.Students.ToArray();
      Department[] dept = _db.Departments.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("courses", crs);
      model.Add("students", stud);
      model.Add("departments", dept);
      return View(model);
    }
  }
}