using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeppApp.Models;

namespace WeppApp.ViewModels
{
    /// <summary>
    /// Use to transfert data from Controller to View Dashboard
    /// </summary>
    public class DashboardViewModel
    {
        public ICollection<VAT> DisplayVATs;
        public ICollection<Category> DisplayCategories;
        public ICollection<Account> DisplayAccounts;
        public ICollection<Classified> DisplayClassifieds;

        public bool IsClickedVAT { get; set; }
        public bool IsClickedAccount { get; set; }
        public bool IsClickedCategory { get; set; }
        public bool IsClickedClassiefed { get; set; }
    }
}