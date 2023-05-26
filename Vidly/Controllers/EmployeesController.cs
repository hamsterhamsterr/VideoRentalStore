using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Employees
        public ActionResult Index()
        {
            var users = _context.Users.ToList();
            var roles = _context.Roles.ToList();

            var employeesVM = new EmployeesViewModel(users, roles);

            return View(employeesVM);
        }

        public ActionResult Details(string id)
        {
            var employee = _context.Users.SingleOrDefault(u => u.Id == id);
            var roles = _context.Roles.ToList();
            var role = roles.SingleOrDefault(r => r.Id == employee.Roles.First().RoleId);


            if (employee == null || role == null)
                return HttpNotFound();

            var employeeDetailsVM = new EmployeeDetailsViewModel
            {
                Employee = employee,
                Role = role
            };

            return View("Employee", employeeDetailsVM);
        }

        public ActionResult Delete(string id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                return HttpNotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}