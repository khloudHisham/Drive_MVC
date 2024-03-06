using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Text;
using Humanizer;
using System.Numerics;

namespace MVCDay2.Controllers
{
    public class CourseNewController : Controller
    {
        MyContext context = new MyContext();
        public IActionResult Show()
        {
            List<Course> listCourse = context.Courses.ToList();
            return View(listCourse);
        }   

        [HttpGet]
        public IActionResult New() 
        {
            ViewBag.DeptList = context.Departments.ToList();
            ViewBag.ResultsList = context.CRSresults.ToList();
            ViewBag.InstList = context.Instractors.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult New(Course course)
        {
            try
            {
                //if (course.CourseName != null)
                if (ModelState.IsValid == true)//Validation server side
                {
                    context.Add(course);
                    context.SaveChanges();
                    return RedirectToAction("Show");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "check any error ");
            }
            ViewBag.ResultsList = context.CRSresults.ToList();
            ViewBag.DeptList = context.Departments.ToList();
            ViewBag.InstList = context.Instractors.ToList();

            return View (course);
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            Course course = context.Courses.Find(id);

            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, string confirmButton)
        {
            Course course = context.Courses.Find(id);

            //if (course == null)
            //{
            //    return NotFound();
            //}

            context.Courses.Remove(course);
            context.SaveChanges();

            return RedirectToAction("Show");
           
        }

        public IActionResult CheckMinDegree(int CourseDegree,int CourseMinDegree)
        {
            if (CourseMinDegree >= CourseDegree)
            {
                return Json(false);
            }

            return Json(true);

        }
      

    }

}
