using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WeppApp.Models
{
    public class Account
    {
        [DisplayName("Identifiant")]
        public int Id { get; set; }
        [DisplayName("Nom")]
        public string FirtName { get; set; }
        [DisplayName("Prénom")]
        public string LastName { get; set; }
        [DisplayName("Date création compte")]
        public DateTime DateCreate { get; set; }
        [DisplayName("Date MAJ cmompte")]
        public DateTime DateUpdate { get; set; }
        [DisplayName("Chiffres des ventes")]
        public float TotalSales { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        
        [DisplayName("Mot de passe")]
        public string Password { get; set; }

        public ICollection<Classified> Classifieds { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}