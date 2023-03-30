using FA.BookStore.Core.Configs;
using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.DataContext
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {

        }
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {
        }



        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=BookStoreDB2;Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
            modelBuilder.SeedData();
        }
    }
}
