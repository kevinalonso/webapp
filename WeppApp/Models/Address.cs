using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        //Foreign key for Account
        public int IdAccount { get; set; }
        public Account Account { get; set; }
    }
}