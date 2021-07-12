using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The movie title is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The movie genre is required")]
        public byte MovieGenreId { get; set; }

        public MovieGenreDTO MovieGenre { get; set; }

        [Required(ErrorMessage = "The Release date is required")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The stock value must be between {1} and {2}")]
        public int Stock { get; set; }
    }
}