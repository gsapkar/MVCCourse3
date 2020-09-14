using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayThree.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayThree.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(DataModel.Employees);
        }

        public IActionResult Details(int id)
        {
            var employee = DataModel.Employees.FirstOrDefault(t => t.ID == id);

            return View(employee);
        }
    }
}
