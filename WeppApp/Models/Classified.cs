using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class Classified
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateSale { get; set; }


        //Foreign key for Category
        public int IdCategory { get; set; }
        public Category Category { get; set; }

        //Foreign key for Account
        public int IdAccount { get; set; }
        public Account Account { get; set; }

        //Foreign key for Vat
        public int IdVat { get; set; }
        public VAT VAT { get; set; }
    }
}