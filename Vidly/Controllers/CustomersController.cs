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
        // GET: Customers
        public ActionResult CustomerTable()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Johny", Id = 1},
                new Customer {Name = "Mary", Id = 2}
            };

            var viewModel = new CustomerTableViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult CustomerDetails(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1 ,Name = "Johny"},
                new Customer {Id = 2 ,Name = "Mary"}
            };

        }
    }
}