using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcLogger.Models;

namespace mvcLogger.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestError()
        {
            int x = 10;
            int y = 0;
            int res = x / y;
            return View(res.ToString());
        }
        //public IActionResult Send()
        //{
        //    TempData["Message"] = "Hello from Home Controller";
        //    //TempData[a]=10;
           
        //    return RedirectToAction("Recieve", "Student");
        //}
        public IActionResult Method()
        {
            TempData["a"] = 10;
            return RedirectToAction("Square", "Math");

        }
        public IActionResult MyName()
        {
            TempData["Name"] = "Shikha";
            TempData["College"] = "LPu";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
