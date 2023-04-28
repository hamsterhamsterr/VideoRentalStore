using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new CustomersViewModel();

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Customer(int id)
        {
            var customer = new CustomersViewModel().GetCustomerById(id);

            if (customer == null)
                return HttpNotFound();

            return View("Customer", customer);
        }
    }
}