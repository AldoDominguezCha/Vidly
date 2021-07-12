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
            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View();
            }
            
             return View("ReadOnlyIndex");
            
            
        }

        [Route("movies/new")]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genres = _context.MovieGenres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genres
            };

            ViewBag.ActionTitle = "New";

            return View("MovieForm", viewModel);

        }

        [HttpPost]
        [Route("movies/save")]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
        
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Genres = _context.MovieGenres.ToList(),
                    Movie = movie
                };

                ViewBag.ActionTitle = "Edit";
                return View("MovieForm", viewModel);
            }
            
            if (movie.Id == 0)
            {
                movie.AdditionDate = DateTime.Today;

                _context.Movies.Add(movie);
            }

            else
            {
                var dbMovie = _context.Movies.Single(m => m.Id == movie.Id);

                dbMovie.Name = movie.Name;
                dbMovie.ReleaseDate = movie.ReleaseDate;
                dbMovie.MovieGenreId = movie.MovieGenreId;
                dbMovie.Stock = movie.Stock;
            }

            
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            var genres = _context.MovieGenres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genres
            };

            ViewBag.ActionTitle = "Edit";
            return View("MovieForm", viewModel);
        }
    }
}