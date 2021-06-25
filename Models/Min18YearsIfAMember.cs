using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = validationContext.ObjectInstance as Customer;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            
            if (customer.Birthdate == null)
            {
                return new ValidationResult("The date of birth is required");
            }

            var age = DateTime.Today.Year - customer.Birthdate.GetValueOrDefault().Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("You must be at least 18 years old to select a recurrent membership type");
        }
    }
}