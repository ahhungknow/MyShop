using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data
{
    public class MyShopDbContext:DbContext
    {
        public MyShopDbContext():base("MyShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slide> Slides { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
