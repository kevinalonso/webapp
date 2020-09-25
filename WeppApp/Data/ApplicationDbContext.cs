using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeppApp.Models;

namespace WeppApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WebAppConnectionString")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Test> Test { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<VAT> VAT { get; set; }
        public DbSet<Classified> Classified { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}