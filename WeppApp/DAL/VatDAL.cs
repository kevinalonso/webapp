using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeppApp.Data;
using WeppApp.Models;

namespace WeppApp.DAL
{
    public class VatDAL : DbContext
    {
        /// <summary>
        /// Create vat and adress for this vat
        /// </summary>
        /// <param name="vat"></param>
        public void CreateVAT(VAT vat)
        {
            var context = new ApplicationDbContext();
            context.VAT.Add(vat);
            context.SaveChanges();
        }

        /// <summary>
        /// Update vat or address
        /// </summary>
        /// <param name="vat"></param>
        public void UpdateVAT(VAT vat)
        {
            var context = new ApplicationDbContext();
            var data = context.VAT.First<VAT>();
            data = vat;
            context.SaveChanges();
        }

        /// <summary>
        /// Delete vat and address
        /// </summary>
        /// <param name="vat"></param>
        public void DeleteVAT(VAT vat)
        {
            var context = new ApplicationDbContext();
            var data = context.VAT.First<VAT>();
            context.VAT.Remove(data);
            context.SaveChanges();
        }

        /// <summary>
        /// Return one vat
        /// </summary>
        /// <param name="vat"></param>
        /// <returns></returns>
        public VAT GetVAT(VAT vat)
        {
            var context = new ApplicationDbContext();
            return context.VAT.Where(tmp => tmp.Id == vat.Id).FirstOrDefault<VAT>();
        }

        /// <summary>
        /// Return all VAT
        /// </summary>
        /// <returns></returns>
        public ICollection<VAT> GetVATs()
        {
            ICollection<VAT> vATs;
            var context = new ApplicationDbContext();
            vATs = context.VAT.ToList();

            return vATs;
        }
    }
}