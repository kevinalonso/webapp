using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public float TotalSales { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Classified> Classifieds { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}