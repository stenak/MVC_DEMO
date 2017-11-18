using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith", BirthYear = 1988 },
                new Customer { Id = 2, Name = "Boris Petrusevski", BirthYear = 2010 },
                new Customer { Id = 3, Name = "Kire Nakevski", BirthYear = 1995 },
                new Customer { Id = 4, Name = "Valentina Dimovska", BirthYear = 1988 },
                new Customer { Id = 5, Name = "Steve Nakevski", BirthYear = 1989 },
                new Customer { Id = 6, Name = "Mary Williams", BirthYear = 1972 }
            };
        }
    }
}