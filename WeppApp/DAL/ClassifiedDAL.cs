using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeppApp.Data;
using WeppApp.Models;

namespace WeppApp.DAL
{
    public class ClassifiedDAL : DbContext
    {
        /// <summary>
        /// Create classified and adress for this classified
        /// </summary>
        /// <param name="classified"></param>
        public void CreateClassified(Classified classified)
        {
            var context = new ApplicationDbContext();
            context.Classified.Add(classified);
            context.SaveChanges();
        }

        /// <summary>
        /// Update classified or address
        /// </summary>
        /// <param name="classified"></param>
        public void UpdateClassified(Classified classified)
        {
            var context = new ApplicationDbContext();
            var data = context.Classified.First<Classified>();
            data = classified;
            context.SaveChanges();
        }

        /// <summary>
        /// Delete classified and address
        /// </summary>
        /// <param name="classified"></param>
        public void DeleteClassified(Classified classified)
        {
            var context = new ApplicationDbContext();
            var data = context.Classified.First<Classified>();
            context.Classified.Remove(data);
            context.SaveChanges();
        }

        /// <summary>
        /// Return one classified
        /// </summary>
        /// <param name="classified"></param>
        /// <returns></returns>
        public Classified GetClassified(Classified classified)
        {
            var context = new ApplicationDbContext();
            return context.Classified.Where(tmp => tmp.Id == classified.Id).FirstOrDefault<Classified>();
        }

        /// <summary>
        /// Return all accounts
        /// </summary>
        /// <returns></returns>
        public ICollection<Classified> GetClassifieds()
        {
            ICollection<Classified> classifieds;
            var context = new ApplicationDbContext();
            classifieds = context.Classified.ToList();

            return classifieds;
        }
    }
}