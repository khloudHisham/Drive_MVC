using Microsoft.AspNetCore.Mvc;
using MVCDay2.Models;

namespace MVCDay2.Controllers
{
    public class CourseController : Controller
    {
        MyContext Context = new MyContext();
        public IActionResult All()
        {

            List<Instractor> InstractorList = Context.Instractors.ToList();


            return View(InstractorList);

        }


        public IActionResult Detail(int id)
        {
            Instractor InstractorModel = Context.Instractors.FirstOrDefault(x => x.Id == id);

            ViewData["Message"] = "Hello";
            ViewData["Fav CLR"] = "red";

            return View (InstractorModel);

        }
    }
}
