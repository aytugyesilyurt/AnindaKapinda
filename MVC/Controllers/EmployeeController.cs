using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult List(int userId)
        {
            return View(_employeeService.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeService.Add(employee);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction("List");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.Delete(employee);
            return RedirectToAction("List");
        }
    }
}
