using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Enes",
                "Beyza"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
               new Employee(){Id=1, FirstName="Enes", LastName="Büyükbaş", Age=23}, 
               new Employee(){Id=2, FirstName="Beyza", LastName="Yüksel", Age=22}, 
               new Employee(){Id=3, FirstName="Serdar", LastName="Tekin", Age=19}, 
            };
            return View("Index3", list);
        }
        
    }
}