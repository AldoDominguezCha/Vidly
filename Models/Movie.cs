using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  MovieGenre MovieGenre { get; set; }
        
        [Display(Name = "Movie genre")]
        public byte MovieGenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AdditionDate { get; set; }
        public int Stock { get; set; }
    }
}