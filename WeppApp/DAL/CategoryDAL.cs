using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeppApp.Data;
using WeppApp.Models;

namespace WeppApp.DAL
{
    public class CategoryDAL : DbContext
    {
        /// <summary>
        /// Create category and adress for this category
        /// </summary>
        /// <param name="category"></param>
        public void CreateCategory(Category category)
        {
            var context = new ApplicationDbContext();
            context.Category.Add(category);
            context.SaveChanges();
        }

        /// <summary>
        /// Update category or address
        /// </summary>
        /// <param name="category"></param>
        public void UpdateCategory(Category category)
        {
            var context = new ApplicationDbContext();
            var data = context.Category.First<Category>();
            data = category;
            context.SaveChanges();
        }

        /// <summary>
        /// Delete category and address
        /// </summary>
        /// <param name="category"></param>
        public void DeleteCategory(Category category)
        {
            var context = new ApplicationDbContext();
            var data = context.Category.First<Category>();
            context.Category.Remove(data);
            context.SaveChanges();
        }

        /// <summary>
        /// Return one category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public Category GetCategory(Category category)
        {
            var context = new ApplicationDbContext();
            return context.Category.Where(tmp => tmp.Id == category.Id).FirstOrDefault<Category>();
        }

        /// <summary>
        /// Return all accounts
        /// </summary>
        /// <returns></returns>
        public ICollection<Category> GetCategorys()
        {
            ICollection<Category> categories;
            var context = new ApplicationDbContext();
            categories = context.Category.ToList();

            return categories;
        }
    }
}