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
        
        [Required(ErrorMessage = "The movie title is required")]
        [Display(Name = "Movie title")]
        public string Name { get; set; }
        
        public  MovieGenre MovieGenre { get; set; }
        
        [Required(ErrorMessage = "The movie genre is required")]
        [Display(Name = "Movie genre")]
        public byte MovieGenreId { get; set; }

        [Required(ErrorMessage = "The Release date is required")]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }
        public DateTime? AdditionDate { get; set; }
        [Range(1, 20, ErrorMessage = "The stock value must be between {1} and {2}")]
        public int Stock { get; set; }
    }
}