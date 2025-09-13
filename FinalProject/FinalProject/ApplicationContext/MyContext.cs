using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.ApplicationContaxt
{
    public class MyContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "server=DESKTOP-TS5LL2V\\SQLEXPRESS;database=FinalProject;Trusted_Connection=true; Encrypt=false;";
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Reposetory resposetory = new Reposetory();
            var users = resposetory.GetUsers();
            var products = resposetory.GetProducts();
            var categories = resposetory.GetCategories();

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Category>().HasData(categories);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}
