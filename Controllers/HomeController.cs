using GenericRepository.IRepository;
using GenericRepository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employee;

        public HomeController(IEmployeeRepository employee)
        {
            _employee = employee;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _employee.FindAll(); 
            return View(employees);
        }
        [HttpGet]

        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employee.Create(employee);
            _employee.Save();
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _employee.FindById(Id);

            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employee.Delete(employee);
            _employee.Save();
            return View();
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var employee = _employee.FindById(Id);
            return View(employee);
        }
        public IActionResult Edit(int Id)
        {
            var employee = _employee.FindById(Id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employee.Upadate(employee);
            _employee.Save();
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
