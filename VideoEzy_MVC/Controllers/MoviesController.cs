using System.Web.Mvc;
using VideoEzy_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace VideoEzy_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().FirstOrDefault(m => m.Id == id);
            return View(movie);
        }
        
        public List<Movie> GetMovies()
        {
            var movies = new List<Movie>
            {
                new Movie{Id=1,Name="Soodhukavum"},
                new Movie{Id=2,Name="Junga"},
                new Movie{Id=3,Name="96"}
            };

            return movies;
        }
    }
}