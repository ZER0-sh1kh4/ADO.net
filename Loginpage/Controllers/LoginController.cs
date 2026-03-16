using Loginpage.Services;
using Microsoft.AspNetCore.Mvc;


namespace Loginpage.Controllers
{
    [Route("account")]
    public class LoginController : Controller
    {
        private readonly IStudentService _service;

        public LoginController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(string name, string password)
        {
            var student = _service.Login(name, password);

            if (student != null)
            {
                return RedirectToAction("Marks", "Student",
                new { id = student.Id });
            }

            ViewBag.Error = "Invalid Credentials";
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
