using HomeworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkCore.Data
{
    public class AppDB : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.\SQLEXPRESS; Initial Catalog = Books; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Books;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasData(
                    new Genre[]
                    {
                        new Genre { Id = 1, Name = "first Genre"},
                        new Genre { Id = 2, Name = "second Genre"},
                        new Genre { Id = 3, Name = "third Genre"}
                    }
                );
            modelBuilder.Entity<Book>()
                .HasData(
                    new Book[]
                    {
                        new Book { Id = 1, Name="first book", Author = "1 author",Publisher = "1 Publisher", year = 2000,GenreId = 1 },
                        new Book { Id = 2, Name = "second book" , Author = "2 author",Publisher = "2 Publisher", year = 2001,GenreId = 1},
                    }
                );
        }

    }
}
