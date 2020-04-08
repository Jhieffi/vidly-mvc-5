using System.Collections.Generic;
using System.Web.Mvc;
using VidlyExercise.Models;

namespace VidlyExercise.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie(1, "Shrek"),
                new Movie(2, "Wall-e"),
                new Movie(3, "Onde os fracos não tem vez!"),
                new Movie(4, "End-Game"),
                new Movie(5, "Harry Potter"),
                new Movie(6, "O lobo de wall street")
            };

            return View(movies);
        }
    }
}