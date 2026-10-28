using EF_Assighnment1.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Assighnment1
{
    internal class BookStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

         public DbSet<Book> books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    }
}
