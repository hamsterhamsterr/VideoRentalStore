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
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1, Name = "John", LastName = "Smith"
                },
                new Customer
                {
                    Id = 2, Name = "Mary", LastName = "Williams"
                }
            };

            var viewModel = new CustomersViewModel();

            return View(viewModel);
        }

        [Route("Details/{id}")]
        public ActionResult Customer(int id)
        {
            var customer = new CustomersViewModel().GetCustomerById(id);

            return View("Customer", customer);
        }
    }
}