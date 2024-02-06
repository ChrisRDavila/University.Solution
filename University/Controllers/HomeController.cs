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
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("students", crs);
      model.Add("students", stud);
      return View(model);
    }
  }
}