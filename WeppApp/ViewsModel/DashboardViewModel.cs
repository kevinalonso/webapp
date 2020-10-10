using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeppApp.Models;

namespace WeppApp.ViewModels
{
    public class DashboardViewModel
    {
        public ICollection<VAT> DisplayVATs;
        public ICollection<Category> DisplayCategories;
        public ICollection<Account> DisplayAccounts;
        public ICollection<Classified> DisplayClassifieds;
    }
}