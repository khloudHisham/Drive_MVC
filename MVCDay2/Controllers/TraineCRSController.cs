using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.EntityFrameworkCore;
using MVCDay2.Models;
using MVCDay2.ViewModel;

namespace MVCDay2.Controllers
{
    
    public class TraineCRSController : Controller
    {
        MyContext Context = new MyContext();

        public IActionResult Index(int id , int CrsId)
        {
            var traineeCourseResult = Context.CRSresults
            .Include(rc => rc.Trainee)
            .Include(rc => rc.Course)
            .FirstOrDefault(r => r.TRId == id && r.CourseId == CrsId);

            if (traineeCourseResult == null)
            {
                return HttpNotFound();
            }
             bool IsPass = (traineeCourseResult.CrsDegree >= traineeCourseResult.Course.CourseMinDegree);
             ViewBag.StatusColor = IsPass ? "green" : "red";
           
            TraineCourseDegreeViewModel viewModel = new TraineCourseDegreeViewModel()
            {
                TrName = traineeCourseResult.Trainee.TrName,
                CourseName = traineeCourseResult.Course.CourseName,
                CourseDegre = traineeCourseResult.CrsDegree,
                IsPass = IsPass,
            };
            return View(viewModel);
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
