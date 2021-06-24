using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: Movies/Random

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        [Route("movies/{id}")]
        public ActionResult DisplayMovieByID(int id)
        {
            var specificMovie = _context.Movies.Include(m => m.MovieGenre).SingleOrDefault(m => m.Id == id);
            if (specificMovie == null)
            {
                return HttpNotFound();
            }

            return View(specificMovie);
        }

        [Route("movies/new")]
        public ActionResult New()
        {
            var genres = _context.MovieGenres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);

        }
    }
}