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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Index()
        {
            var viewModel = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Customer(int id)
        {
            //var customer = new CustomersViewModel().GetCustomerById(id);
            var customer = _context.Customers
                .Include(c => c.MembershipType)
                .SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View("Customer", customer);
        }
    }
}