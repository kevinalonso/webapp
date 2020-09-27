using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class VAT
    {
        public int Id { get; set; }
        public float Vat { get; set; }

        public ICollection<Classified> Classifieds { get; set; }
    }
}