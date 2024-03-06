using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;
using Microsoft.EntityFrameworkCore;
using MVCDay2.ViewModel;
using System.Drawing;

namespace MVCDay2.Controllers
{
   
    public class BonusCrsController : Controller
    {
        MyContext Context = new MyContext();

        public IActionResult Bonus(int id)
        {
            var traineeCourseResult = Context.CRSresults
           .Include(rc => rc.Trainee)
           .Include(rc => rc.Course).Where(r => r.CourseId == id).ToArray();
        

            var CourseResults1 = traineeCourseResult.Select(rc => new BonusShowCrsTrViewModel
            {
                TraineeName = rc.Trainee.TrName,
                ResultDegree = rc.CrsDegree,
                Color = rc.CrsDegree >= rc.Course.CourseMinDegree ? "green" : "red"

            }).ToList();

            //CourseResults.Add(new BonusShowCrsTrViewModel()
            //{
            //    TraineeName = traineeCourseResult.Trainee.TrName,
            //    ResultDegree = traineeCourseResult.CrsDegree,
            //    Color = Colorrow
            //});
            //var CourseResults1 = traineeCourseResult.Course.Select(rc => new BonusShowCrsTrViewModel
            //{
            //    TraineeName = rc.Trainee.TrName,
            //    ResultDegree = rc.CrsDegree,
            //    Color = Colorrow,
            //    IsPass = IsPass
            //}).ToList();

            return View(CourseResults1);
        }
    }
}