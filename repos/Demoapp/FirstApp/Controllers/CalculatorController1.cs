using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Heading = "Calculator applicaton";
            return View();
        }
        public IActionResult Greeting()
        {
            return View();
        }
        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "Dharan";
            person.Basic_Salary = 10000;
            person.Age = 21;
            return View(person);
        }

        
        
    }
}
