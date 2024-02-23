using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Data;
using PracticeMVC.Models;

namespace PracticeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController( ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employeeList = _context.Employee.ToList();
           return View(employeeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            
            return View();
        }
    }
}
