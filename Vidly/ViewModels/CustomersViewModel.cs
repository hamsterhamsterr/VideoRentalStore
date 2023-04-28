using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Collections;

namespace Vidly.ViewModels
{
    public class CustomersViewModel
    {
        private Dictionary<int, Customer> _customers;

        public CustomersViewModel()
        {
            _customers = new Dictionary<int, Customer>();
            _customers.Add(
                1, new Customer { Id = 1, Name = "John", LastName = "Smith" });
            _customers.Add(
                2, new Customer { Id = 2, Name = "Mary", LastName = "Williams" });

        }

        public Customer GetCustomerById(int id)
        {
            return _customers[id];
        }

        public IEnumerable<Customer> Customers { get { return _customers.Values; } }
    }
}