using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class DisplayCustomersViewModel
    {
        public List<Customer> Customers { get; set; }

        public DisplayCustomersViewModel()
        {
            Customers = new List<Customer>();
        }

        public void LoadTestCustomers()
        {
            Customers.Add(new Customer { Id = 2, Name = "Aldo" });
            Customers.Add(new Customer { Id = 17, Name = "Mosh" });
            Customers.Add(new Customer { Id = 10, Name = "Chris" });
            Customers.Add(new Customer { Id = 25, Name = "James" });
        }
    }
}