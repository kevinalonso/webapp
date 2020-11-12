using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeppApp.Data;
using WeppApp.Models;

namespace WeppApp.DAL
{
    public class AccountDAL : DbContext
    {
        /// <summary>
        /// Create account and adress for this account
        /// </summary>
        /// <param name="account"></param>
        public void CreateAccount(Account account)
        {
            var context = new ApplicationDbContext();
            context.Account.Add(account);
            context.SaveChanges();
        }

        /// <summary>
        /// Update account or address
        /// </summary>
        /// <param name="account"></param>
        public void UpdateAccount(Account account)
        {
            var context = new ApplicationDbContext();
            var data = context.Account.First<Account>();
            data = account;
            context.SaveChanges();
        }

        /// <summary>
        /// Delete account and address
        /// </summary>
        /// <param name="account"></param>
        public void DeleteAccount(Account account)
        {
            var context = new ApplicationDbContext();
            var data = context.Account.First<Account>();
           context.Account.Remove(data);
            context.SaveChanges();
        }

        /// <summary>
        /// Return one account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Account GetAccount(Account account)
        {
            var context = new ApplicationDbContext();
            return context.Account.Where(tmp => tmp.Id == account.Id).FirstOrDefault<Account>();
        }

        /// <summary>
        /// Return all accounts
        /// </summary>
        /// <returns></returns>
        public ICollection<Account> GetAccounts()
        {
            ICollection<Account> accounts;
            var context = new ApplicationDbContext();
            accounts = context.Account.Include(c => c.Classifieds).ToList();
            return accounts;
        }
    }
}