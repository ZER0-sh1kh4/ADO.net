using Microsoft.AspNetCore.Mvc;

namespace mvcLogger.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Recieve()
        //{
        //    var msg = TempData["Message"];
        //    return Content(msg?.ToString());
        //}
        public IActionResult Square()
        {
            int number = Convert.ToInt32(TempData["a"]);
            int result = number * number;

            return Content("Square is: " + result);
        }
    }
    }

