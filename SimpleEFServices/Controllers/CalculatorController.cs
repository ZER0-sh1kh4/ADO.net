using Microsoft.AspNetCore.Mvc;
using SimpleEFServices.Services;

namespace SimpleEFServices.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorServices _calculator;
        public CalculatorController(CalculatorServices calculator)
        {
            _calculator = calculator;
        }
        public IActionResult Add()
        {
            var result = _calculator.Add(5,3);
            return Content("Result=" + result);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
