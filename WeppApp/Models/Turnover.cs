using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class Turnover
    {
        public int Id { get; set; }

        public ICollection<Classified> Classifieds { get; set; }
    }
}