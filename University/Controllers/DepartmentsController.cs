using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace University.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly UniversityContext _db;

    public DepartmentsController(UniversityContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Details(int id)
    {
      Department thisDepartment = _db.Departments
          .Include(department => department.Courses)
          .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
    {
      _db.Departments.Add(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Edit(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost]
    public ActionResult Edit(Department department)
    {
      _db.Departments.Update(department);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      return View(thisDepartment);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Department thisDepartment = _db.Departments.FirstOrDefault(departments => departments.DepartmentId == id);
      _db.Departments.Remove(thisDepartment);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}