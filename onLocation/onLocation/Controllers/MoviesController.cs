using onLocation.Models;
using System.Web.Mvc;

namespace onLocation.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            MovieSearch movie = new MovieSearch() { Name = "Shrek" };
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}