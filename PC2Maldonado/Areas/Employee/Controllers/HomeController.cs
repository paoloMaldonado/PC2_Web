using Microsoft.AspNetCore.Mvc;
using PC2Maldonado.Areas.Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC2Maldonado.Areas.Employee.Controllers
{
    [Area("Employee")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<employee>();

            employee e1 = new employee();
            e1.FullName = "Paolo Maldonado";
            e1.Email = "123@hotmail.com";
            e1.Country = "Peru";
            e1.Age = 21;
            e1.Id = 1;

            employees.Add(e1);

            return View(employees);
        }
    }
}
