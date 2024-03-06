        using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MVCDay2.Models;
using MVCDay2.Repository;
using MVCDay2.ViewModel;
using NuGet.Configuration;

namespace MVCDay2.Controllers
{
    public class InstractorListNewController : Controller
    {
        // MyContext Context = new MyContext();
        IInstractorRepos InsRepo;
        IDepartmentRepos DepartRepo;
        ICourseRepos CourseRepo;

        public InstractorListNewController(IInstractorRepos insRepo, IDepartmentRepos departRepo,ICourseRepos courseRepos)
        {
            InsRepo = insRepo;
            DepartRepo = departRepo;
           CourseRepo = courseRepos;
        }

        public IActionResult Show()
        {
            var Inslist = CourseRepo.GetInsShows().Select(i => new InsShowViewModel
            {
                Id = i.Id,
                Name = i.InsName,
                Salary = i.InsSalary,
                Address = i.InsAddress,
                Image = i.InsImage,
                Cours = i.Course.CourseName,
                Dept = i.Department.DeptName
            }).ToList();
            return View(Inslist);
            //var Inslist = InsRepo.GetAll();
            //var Departlist = DepartRepo.GetAll();
            //var Courselist = CourseRepo.GetAll();
            //var insmodel = Inslist.Select(i => new InsShowViewModel
            // {
            //    Id = i.Id,
            //     Name = i.InsName,
            //     Salary = i.InsSalary,
            //     Address = i.InsAddress,
            //     Image = i.InsImage,
            //     Cours = i.Course.CourseName,
            //     Dept = i.Department.DeptName
            // })
            //.ToList();
            // return View(insmodel);
            //var Inslist = Context.Instractors
            //.Include(i => i.Course)
            //.Include(i => i.Department)
            //.Select(i => new InsShowViewModel
            //{
            //    Id = i.Id,
            //    Name = i.InsName,
            //    Salary = i.InsSalary,
            //    Address = i.InsAddress,
            //    Image = i.InsImage,
            //    Cours = i.Course.CourseName,
            //    Dept = i.Department.DeptName
            //})
            //.ToList();

            //return View(Inslist);
        }


        public IActionResult NewView() 
        {
            var viewModel = new InstractorNewListViewModel
            {
                CrsList = CourseRepo.GetAll(),
                DeptList = DepartRepo.GetAll()
                // CrsList = Context.Courses.ToList(),
                //DeptList = Context.Departments.ToList()

            };
            return View(viewModel);
            
        }
        [HttpPost]
        public IActionResult SaveNew(InstractorNewListViewModel inst)
        {

            if (inst.Name != null )
            {

                var instractor = new Instractor
                {
                    InsName = inst.Name,
                    InsSalary = inst.Salary,
                    InsAddress = inst.Address,
                    InsImage = inst.Image,
                    CourseId = inst.CourseId,
                    DeptId = inst.DeptId

                };
                InsRepo.Insert(instractor);
                InsRepo.Save();
                //Context.Instractors.Add(instractor);
                //Context.SaveChanges();
                return RedirectToAction("Show");
            }
            else
            {
                inst.CrsList = CourseRepo.GetAll();
                inst.DeptList = DepartRepo.GetAll();
                //inst.CrsList = Context.Courses.ToList();
                //inst.DeptList = Context.Departments.ToList();
                return View("NewView", inst);
            }
           
        }

        public IActionResult GetCrsByDept(int Id)
        {
            var courses = CourseRepo.GetByDepartmentId(Id);
            return Json(courses);
            
               // .Where(c => c.DeptId == Id).ToList();
            //var Courses = Context.Courses
            //   .Where(c => c.DeptId == Id).ToList();
           // return Json(Courses);
        }

        public IActionResult Edit(int id) 
            {
            Instractor insedit = InsRepo.GetById(id);
            ViewBag.Deptlist = DepartRepo.GetAll();
            ViewBag.crslist = CourseRepo.GetAll();
            //Instractor insedit = Context.Instractors.FirstOrDefault(x => x.Id == id);
            //ViewBag.Deptlist = Context.Departments.ToList();
            //ViewBag.crslist= Context.Courses.ToList() ;

            return View(insedit); 
            }

        [HttpPost]
        public IActionResult SaveEdit(Instractor insedit)
        {
            if (insedit.InsName != null)
            {

                InsRepo.Edit(insedit);
                InsRepo.Save();
                //Context.Update(insedit);
                //Context.SaveChanges();
                return RedirectToAction("Show");
            }
            else
            {
                ViewBag.Deptlist = DepartRepo.GetAll();
                ViewBag.crslist = CourseRepo.GetAll();
                //ViewBag.CrsList = Context.Courses.ToList();
                //ViewBag.DeptList = Context.Departments.ToList();
                return View("Edit", insedit);
            }
        }
        //public IActionResult Edit(int? id)
        //{
        //    var instractor = Context.Instractors.Find(id);

        //    if (instractor == null)
        //    {
        //        return NotFound();
        //    }

        //    var EditModel = new InstractorNewListViewModel
        //    {
        //        Id = instractor.Id,
        //        Name = instractor.InsName,
        //        Image = instractor.InsImage,
        //        Salary = instractor.InsSalary,
        //        Address = instractor.InsAddress,
        //        CrsList = Context.Courses.ToList(),
        //        DeptList = Context.Departments.ToList()

        //    };

            //public IActionResult SaveEdit(InstractorNewListViewModel insedit)
            //{
            //    if (insedit.Name != null)
            //    {

            //        //var instractoredit = new Instractor
            //        //{
            //        //    InsName = insedit.Name,
            //        //    InsSalary = insedit.Salary,
            //        //    InsAddress = insedit.Address,
            //        //    InsImage = insedit.Image,
            //        //    CourseId = insedit.CourseId,
            //        //    DeptId = insedit.DeptId

            //        //};
            //        Context.Update(insedit);
            //        Context.SaveChanges();
            //        return RedirectToAction("Show");
            //    }
            //    else
            //    {
            //        insedit.CrsList = Context.Courses.ToList();
            //        insedit.DeptList = Context.Departments.ToList();
            //        return View("Edit", insedit);
            //    }
            //}





        }
}
