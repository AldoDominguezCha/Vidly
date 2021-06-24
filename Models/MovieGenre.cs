using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class MovieGenre
    {
        public int Id { get; set; }
        
        public string GenreName { get; set; }
    }
}