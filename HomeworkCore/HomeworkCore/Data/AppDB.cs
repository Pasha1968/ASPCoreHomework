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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.\SQLEXPRESS; Initial Catalog = Books; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Books;Trusted_Connection=True;");
        }
    }
}
