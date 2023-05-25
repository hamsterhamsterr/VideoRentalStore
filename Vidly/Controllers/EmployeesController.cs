using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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
    }
}