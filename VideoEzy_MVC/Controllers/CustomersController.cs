using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VideoEzy_MVC.Models;

namespace VideoEzy_MVC.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext dbContext = null;

        public CustomersController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = dbContext.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                var customers = dbContext.Customers.Include(c => c.MembershipType).FirstOrDefault(c => c.Id == id);
                if (customers != null)
                {
                    return View(customers);
                }
                else
                {
                    return new HttpNotFoundResult("Customer ID does not exist");
                }
            }
            else
            {
                return new HttpNotFoundResult("Path does not exist");
            }
        }

    }
}