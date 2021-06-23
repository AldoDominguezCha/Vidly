using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class DisplayMoviesViewModel
    {
        public List<Movie> Movies { get; set; }

        public DisplayMoviesViewModel()
        {
            Movies = new List<Movie>();
        }
        public void LoadTestMovies()
        {
            Movies.Add(new Movie { Id = 1, Name = "The Jungle Book" });
            Movies.Add(new Movie { Id = 2, Name = "Blade Runner" });
            Movies.Add(new Movie { Id = 3, Name = "Zootopia" });
            Movies.Add(new Movie { Id = 4, Name = "The Great Budapest Hotel" });
        }
    }
}