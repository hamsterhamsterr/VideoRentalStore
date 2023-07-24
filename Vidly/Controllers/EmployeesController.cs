using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

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
            if (User.IsInRole(RoleName.Employee))
                return RedirectToAction("AccessDenied", "Errors");

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

            var viewModel = new EmployeeDetailsViewModel
            {
                Employee = employee,
                Role = role
            };

            return View("Employee", viewModel);
        }
        [AuthorizeEmployee(Roles = RoleName.Admin)]
        public ActionResult Edit(string id)
        {
            var employee = _context.Users.SingleOrDefault(u => u.Id == id);
            var roles = _context.Roles.ToList();
            var role = roles.SingleOrDefault(r => r.Id == employee.Roles.First().RoleId);

            if (employee == null || role == null)
                return HttpNotFound();

            var viewModel = new EmployeeDetailsViewModel
            {
                Employee = employee,
                Role = role
            };

            return View("EmployeeForm", viewModel);
        }

        [AuthorizeEmployee(Roles = RoleName.Admin)]
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