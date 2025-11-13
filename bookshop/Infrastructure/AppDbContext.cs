using bookshop.Entities;
using Microsoft.EntityFrameworkCore;

namespace bookshop.Infrastructure
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString: @"Server=LAPTOP-LCL3BM4M\SQLEXPRESS;Database=bookshop;Integrated Security=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
         
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                 new Category(){Id = 1 ,  Name= "جناعی" , },
                 new Category(){Id = 2 ,  Name = "داستانی" , }
            });

            modelBuilder.Entity<book>().HasData(new List<book>()
            {
                new book() {Id  = 1 , Title = "سوشون" , Author = "Writer1" ,   pagecount = 100 ,CategoryId = 2 , },
                new book() {Id  = 2 , Title = "بخش دی" , Author = "Writer2" ,   pagecount = 200 ,CategoryId = 1 , },
                new book() {Id  = 3 , Title = "بامدادخمار" , Author = "Writer1" ,   pagecount = 100 ,CategoryId = 2 , }
            });

            modelBuilder.Entity<User>().HasData(new List<User>()
            {
                new User() {Id  = 1 , Username = "ali" , PasswordHash = "0123" , },
                new User() {Id  = 2 , Username = "Rasool" , PasswordHash = "4567" ,  },
                new User() {Id  = 3 , Username = "ftm" , PasswordHash = "8910" ,  }
            });


            base.OnModelCreating(modelBuilder);
        }

    }
}
