using Microsoft.AspNetCore.Mvc;


namespace MVCDay2.Controllers
{
    public class PassActionController : Controller
    {
       
        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("Name", "BASMA");
            HttpContext.Session.SetString("Country", "Egypt");
            HttpContext.Session.SetInt32("Age", 23);
            return Content("Session saved");
            
        }
        public IActionResult GetSession()
        {
            string name = HttpContext.Session.GetString("Name");
            string Country = HttpContext.Session.GetString("Country");
            int age = HttpContext.Session.GetInt32("Age").Value;
            return Content($"name={name} \n Country={Country}\n age={age}");
        }
    }
}
