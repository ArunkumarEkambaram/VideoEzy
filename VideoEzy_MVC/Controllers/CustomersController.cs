using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VideoEzy_MVC.Models;

namespace VideoEzy_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().FirstOrDefault(c => c.Id == id);
            return View(customers);
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,Name="Bathri"},
                new Customer{Id=2,Name="Pavan"},
                new Customer{Id=3,Name="Kayal"}
            };

            return customers;
        }
    }
}