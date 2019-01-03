using System.Web.Mvc;
using VideoEzy_MVC.Models;

namespace VideoEzy_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        
        
    }
}