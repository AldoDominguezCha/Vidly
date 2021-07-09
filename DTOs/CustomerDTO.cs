using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "You must select a membership type")]
        public byte MembershipTypeId { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}